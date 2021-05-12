using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment.Models
{
    public class UserRole
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string UserRoleName { get; set; }
    }
}
