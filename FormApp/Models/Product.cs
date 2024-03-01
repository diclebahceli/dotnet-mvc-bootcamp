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
        [Required]
        [StringLength(100)]
        public string BookName { get; set; } = null!;


        [Display(Name = "PageCount")]
        [Required]
        [Range(0, 1500)]
        public int? PageCount { get; set; }
        [Display(Name = "Image")]
        [Required]
        public string Image { get; set; } = string.Empty;
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
        [Display(Name = "CategoryId")]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}