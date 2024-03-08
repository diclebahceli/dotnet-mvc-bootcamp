using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class BootcampViewModel
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public int? TeacherId { get; set; }

    }
}