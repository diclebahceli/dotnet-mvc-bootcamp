using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }
        public string? StudentEmail { get; set; }
        public string? StudentPhone { get; set; }

        public string NameSurname
        {
            get
            {
                return StudentName + " " + StudentSurname;
            }
        }


    }
}