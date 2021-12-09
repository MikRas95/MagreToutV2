using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.Ads
{
    public class ReadModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty]
        public IEnumerable<DemoAd> ads { get; set; }
        private IMagazine magazine { get;}
        [BindProperty]
        public DemoMagazine Magazine { get; set; }
        private IAd AdService;
        public ReadModel(IAd service, IMagazine mService)
        {
            AdService = service;
            magazine = mService;
            ads = new List<DemoAd>();
        }
        public void OnGet(int id)
        {
            ads = AdService.GetAds(id);
            //ViewData["Name"] = Magazine.Version;
        }
    }
}
