using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EFCore.Views.Student
{
    public class create : PageModel
    {
        private readonly ILogger<create> _logger;

        public create(ILogger<create> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}