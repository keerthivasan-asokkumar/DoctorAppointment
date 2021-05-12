using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoctorAppointment.Models;

namespace DoctorAppointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentDetailsController : ControllerBase
    {
        private readonly UserDBContext _context;

        public AppointmentDetailsController(UserDBContext context)
        {
            _context = context;
        }

        // GET: api/AppointmentDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentDetail>>> GetAppointmentDetails()
        {
            return await _context.AppointmentDetails.ToListAsync();
        }

        // GET: api/AppointmentDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentDetail>> GetAppointmentDetail(int id)
        {
            var appointmentDetail = await _context.AppointmentDetails.FindAsync(id);

            if (appointmentDetail == null)
            {
                return NotFound();
            }

            return appointmentDetail;
        }

        // PUT: api/AppointmentDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointmentDetail(int id, AppointmentDetail appointmentDetail)
        {
            if (id != appointmentDetail.AppointmentId)
            {
                return BadRequest();
            }

            _context.Entry(appointmentDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppointmentDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AppointmentDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AppointmentDetail>> PostAppointmentDetail(AppointmentDetail appointmentDetail)
        {
            _context.AppointmentDetails.Add(appointmentDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointmentDetail", new { id = appointmentDetail.AppointmentId }, appointmentDetail);
        }

        // DELETE: api/AppointmentDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppointmentDetail>> DeleteAppointmentDetail(int id)
        {
            var appointmentDetail = await _context.AppointmentDetails.FindAsync(id);
            if (appointmentDetail == null)
            {
                return NotFound();
            }

            _context.AppointmentDetails.Remove(appointmentDetail);
            await _context.SaveChangesAsync();

            return appointmentDetail;
        }

        private bool AppointmentDetailExists(int id)
        {
            return _context.AppointmentDetails.Any(e => e.AppointmentId == id);
        }
    }
}
