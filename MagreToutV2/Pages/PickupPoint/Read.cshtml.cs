using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.PickupPoint
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
