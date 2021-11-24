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
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; }

        IPickupPoint PickupPointService;

        public DeleteModel(IPickupPoint Context)
        {    
            PickupPointService = Context;
        }   
        public void OnGet(int PickupPointId)
        {
            PickupPoint = PickupPointService.GetPickupPointById(PickupPointId);
        }

        public IActionResult OnPost()
        {
            PickupPointService.DeletePickupPoint(PickupPoint);
            
            return RedirectToPage("/PickupPoint/Read");
        }
        
    }
}
