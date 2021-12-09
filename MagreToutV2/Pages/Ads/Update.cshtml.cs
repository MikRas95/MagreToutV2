using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MalgreToutV2.Pages.Ads
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public DemoAd Ad { get; set; } = new DemoAd();
        public void OnGet(int id)
        {
            Ad = adService.GetAd(id);

        }
        IAd adService;
        public UpdateModel(IAd service)
        {
            this.adService = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            adService.UpdateAd(Ad);
            return RedirectToPage("/Ads/Read", new { id = Ad.VersionId});
        }
    }
}
