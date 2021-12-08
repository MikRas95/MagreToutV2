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
        public DemoMagazine Magazine {get; set;}
        private IAd Service;
        private IMagazine MagazineService;
        [BindProperty]
        public IEnumerable<DemoMagazine> Magazines { get; set; }

        public CreateModel(IAd service, IMagazine magazineService)
        {
            MagazineService = magazineService;
            Service = service;
            Ad = new DemoAd();
        }
        public void OnGet(int id)
        {
            Magazine = MagazineService.GetMagazine(id);
            Magazines = MagazineService.GetMagazines();
            
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Magazines = MagazineService.GetMagazines();
                return Page();
            }
            Service.AddAd(Ad);

            return RedirectToPage("/Ads/Read", new { id = Ad.VersionId});
        }
    }
}
