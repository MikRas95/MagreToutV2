using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Services.Interface;
using MalgreToutV2.Models;

namespace MalgreToutV2.Pages.ContactPerson
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public IEnumerable<DemoPickupPoint> pickupPoints { get; set; }
        [BindProperty]
        public DemoContactPerson ContactPerson { get; set; }
        IPickupPoint PickupPointService;
        IContactPerson ContactPersonService;
        public CreateModel(IContactPerson service, IPickupPoint ppService)
        {
            this.ContactPersonService = service;
            ContactPerson = new DemoContactPerson();
            PickupPointService = ppService;
        }
        public void OnGet()
        {
            pickupPoints = PickupPointService.GetAllPickupPoints();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                pickupPoints = PickupPointService.GetAllPickupPoints();
                return Page();
            }
            ContactPersonService.AddContactPerson(ContactPerson);
            return RedirectToPage("/ContactPerson/Read"); 
            
        }
    }
}
