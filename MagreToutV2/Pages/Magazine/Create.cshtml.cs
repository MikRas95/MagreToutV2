using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MalgreToutV2.Pages.Magazine
{
    public class CreateMode : PageModel
    {
        [BindProperty]
        public DemoMagazine Magazine { get; set; }
        public IMagazine service;


        public CreateMode(IMagazine Service)
        {
            service = Service;
            Magazine = new DemoMagazine();
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
            service.AddMagazine(Magazine);

            return RedirectToPage("/Magazine/Read");
        }
    }
}
