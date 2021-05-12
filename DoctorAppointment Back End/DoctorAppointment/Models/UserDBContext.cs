using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {

        }

        public DbSet<UserDetail> UserDetails { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
    }
}
