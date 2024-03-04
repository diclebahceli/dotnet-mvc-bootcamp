using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FormApp.Views.Home
{
    public class DeleteBooks : PageModel
    {
        private readonly ILogger<DeleteBooks> _logger;

        public DeleteBooks(ILogger<DeleteBooks> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}