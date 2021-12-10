using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Services.Interface;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;


namespace MalgreToutV2.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ILogin Service) {
            _logger = logger;
            service = Service;
        }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        ILogin service;
        public void OnGet() {
        }
        public IActionResult OnPost() {
            if (service.Login(Username, Password)) {
                return RedirectToPage("/FrontPage");
            }
            return Page();

        }
    }
}