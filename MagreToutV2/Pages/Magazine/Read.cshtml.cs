using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.Magazine
{
    public class ReadModel : PageModel
    {
        [BindProperty]
        public IEnumerable<DemoMagazine> magazines { get; set; }
        private IMagazine MagazineService;
        public ReadModel(IMagazine service)
        {
            MagazineService = service;
            magazines = new List<DemoMagazine>();
        }
        public void OnGet()
        {
            magazines = MagazineService.GetMagazines();
        }

    }
}
