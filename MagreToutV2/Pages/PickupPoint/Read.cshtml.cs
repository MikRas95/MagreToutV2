using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MagreToutV2.Models;
using MagreToutV2.Services.EFServices;
using MagreToutV2.Services.Interface;

namespace MagreToutV2.Pages.PickupPoint
{
    public class ReadModel : PageModel
    {
        [BindProperty]
        public IEnumerable<DemoPickupPoint> PickupPoints { get; set; }
        private IPickupPoint PickupPointService;
        public ReadModel(IPickupPoint service)
        {
            PickupPointService = service;
            PickupPoints = new List<DemoPickupPoint>();
        }
        public IActionResult OnGet()
        {
            PickupPoints = PickupPointService.GetAllPickupPoints();
            return Page();
        }

    }
}
