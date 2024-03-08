using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class Teacher
    {

        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public string? TeacherSurname { get; set; }
        public string? TeacherEmail { get; set; }
        public string? TeacherPhone { get; set; }
        public string NameSurname
        {
            get
            {
                return TeacherName + " " + TeacherSurname;
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime? HireDate { get; set; }
        public ICollection<Bootcamp> Bootcamps { get; set; } = new List<Bootcamp>();
    }
}