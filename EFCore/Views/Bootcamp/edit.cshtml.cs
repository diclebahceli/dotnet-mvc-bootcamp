using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EFCore.Views.Bootcamp
{
    public class edit : PageModel
    {
        private readonly ILogger<edit> _logger;

        public edit(ILogger<edit> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}