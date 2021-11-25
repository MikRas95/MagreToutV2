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
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; } = new DemoPickupPoint();
        public void OnGet(int id)
        {
            PickupPoint = pickupPointService.GetPickupPoint(id);
        }
        IPickupPoint pickupPointService;
        public UpdateModel(IPickupPoint service)
        {
            this.pickupPointService = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            pickupPointService.Update(PickupPoint);
            return RedirectToPage("/PickupPoint/Read");
        }
    }
}

