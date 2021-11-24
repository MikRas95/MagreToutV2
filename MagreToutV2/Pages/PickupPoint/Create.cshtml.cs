using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MagreToutV2.Models;
using MagreToutV2.Services.Interface;

namespace MagreToutV2.Pages.PickupPoint
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public IEnumerable<DemoContactPerson> PickupPeople { get; set; }
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; }
        public IPickupPoint service;
        public IContactPerson service2;
        
        public CreateModel(IPickupPoint Service, IContactPerson Service2) {
            service = Service;
            service2 = Service2;
            PickupPoint = new DemoPickupPoint();
        }
        public IActionResult OnGet()
        {
            PickupPeople = service2.GetContactPeople();
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            service.AddPickupPoint(PickupPoint);

            // Check om GetPickupPoints er det rigtige navn
            return RedirectToPage("/PickupPoint/Read");
        }
    }
}
