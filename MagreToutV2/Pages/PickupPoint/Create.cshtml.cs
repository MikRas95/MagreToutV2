using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.PickupPoint
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; }
        public IGenerics service;

        
        public CreateModel(IGenerics Service) {
            service = Service;
            PickupPoint = new DemoPickupPoint();
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            service.AddAnyObject(PickupPoint);

            // Check om GetPickupPoints er det rigtige navn
            return RedirectToPage("/PickupPoint/Read");
        }
    }
}
