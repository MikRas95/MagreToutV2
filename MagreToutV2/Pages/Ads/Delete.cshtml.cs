using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Services.Interface;
using MalgreToutV2.Models;

namespace MalgreToutV2.Pages.Ads
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public DemoAd Ad { get; set; }
        IAd Service;
        public DeleteModel(IAd service)
        {
            this.Service = service;
        }

        public void OnGet(int AdId)
        {
            Ad = Service.GetAd(AdId);
        }
        public IActionResult OnPost()
        {
            Service.RemoveAd(Ad);
            return RedirectToPage("Read");
        }
    }
}
