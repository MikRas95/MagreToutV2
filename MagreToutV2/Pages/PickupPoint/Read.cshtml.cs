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
        [BindProperty]
        public IEnumerable<DemoContactPerson> ContacPeople { get; set; }
        private IPickupPoint PickupPointService;
        private IContactPerson cService;
        public ReadModel(IPickupPoint service, IContactPerson service2)
        {
            cService = service2;
            PickupPointService = service;
            PickupPoints = new List<DemoPickupPoint>();
            ContacPeople = ContacPeople = cService.GetContactPeople(); 
        }
        public IActionResult OnGet()
        {
            
            PickupPoints = PickupPointService.GetAllPickupPoints();
            return Page();
        }

    }
}
