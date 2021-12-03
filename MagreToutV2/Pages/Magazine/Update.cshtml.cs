using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.Magazine
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public DemoMagazine Magazine { get; set; } = new DemoMagazine();
        public void OnGet(int id)
        {
            Magazine = magazineService.GetMagazine(id);
        }
        IMagazine magazineService;
        public UpdateModel(IMagazine service)
        {
            this.magazineService = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            magazineService.UpdateMagazine(Magazine);
            return RedirectToPage("/Magazine/Read");
        }
    }
}
