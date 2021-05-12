using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndApp.Models
{
    public class AppointmentDetails
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }

        [Required(ErrorMessage = "Please enter the date")]
        [Display(Name = "Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [Required(ErrorMessage = "Please enter the slot")]
        [Display(Name = "Slot")]
        public int AppointmentSlot { get; set; }

        public int IsDeleted { get; set; }

        [Required(ErrorMessage = "Select the doctor")]
        [Display(Name = "Doctor To Consult")]
        public int AppointmentDoctorId { get; set; }

        public DateTime CreatedDatetime { get; set; }
    }
}
