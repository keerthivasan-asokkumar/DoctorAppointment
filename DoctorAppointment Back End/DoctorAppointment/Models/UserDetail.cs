using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment.Models
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }

        [Column (TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string EmailId { get; set; }

        [Column(TypeName = "int")]
        public int UserRoleId { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime CreatedDatetime { get; set; }
    }
}
