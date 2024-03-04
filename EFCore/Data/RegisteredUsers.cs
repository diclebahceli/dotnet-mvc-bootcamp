using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class RegisteredUsers
    {
        [Key]
        public int RegisteredUserId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}