using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MalgreToutV2.Pages.Ads
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public DemoAd Ad { get; set; }
        public IAd service;


        public CreateModel(IAd Service)
        {
            service = Service;
            Ad = new DemoAd();
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            service.AddAd(Ad);

            return RedirectToPage("/Ads/Read");
        }
    }
}
