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
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public DemoMagazine Magazine { get; set; }
        IMagazine Service;
        public DeleteModel(IMagazine service)
        {
            this.Service = service;
        }

        public void OnGet(int id)
        {
            Magazine = Service.GetMagazine(id);
        }

        public IActionResult OnPost()
        {
            Service.RemoveMagazine(Magazine);
            return RedirectToPage("read");
        }
    }
}
