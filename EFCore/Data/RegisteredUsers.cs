using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFCore.Data
{
    public class RegisteredUsers
    {
        [Key]
        public int RegisteredUserId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Bootcamp Course { get; set; } = null;
        public DateTime? RegistrationDate { get; set; }

        public Student Student { get; set; } = null;
    }
}