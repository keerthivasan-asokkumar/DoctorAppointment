using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment.Models
{
    public class AppointmentDetail
    {
        [Key]
        public int AppointmentId { get; set; }

        [Column(TypeName = "int")]
        public int PatientId { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime AppointmentDate { get; set; }

        [Column(TypeName = "int")]
        public int AppointmentSlot { get; set; }

        [Column(TypeName = "int")]
        public int IsDeleted { get; set; }

        [Column(TypeName = "int")]
        public int AppointmentDoctorId { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime CreatedDatetime { get; set; }
    }
}
