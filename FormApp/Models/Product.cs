using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name = "ProductId")]
        public int? ProductId { get; set; }
        [Display(Name = "BookName")]
        public string? BookName { get; set; } = string.Empty;
        [Display(Name = "PageCount")]
        public int? PageCount { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; } = string.Empty;
        [Display(Name = "isActive")]
        public bool isActive { get; set; }
        [Display(Name = "CategoryId")]
        public int CategoryId { get; set; }
    }
}