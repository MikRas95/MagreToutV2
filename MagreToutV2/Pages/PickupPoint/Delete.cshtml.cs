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
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; }

        IPickupPoint PickupPointService;
        IGenerics genericService;

        public DeleteModel(IPickupPoint Context, IGenerics Service)
        {    
            PickupPointService = Context;
            genericService = Service;
        }   
        public void OnGet(int PickupPointId)
        {
            PickupPoint = PickupPointService.GetPickupPointById(PickupPointId);
        }

        public IActionResult OnPost()
        {
            genericService.DeleteAnyObject<DemoPickupPoint>(PickupPoint);
            
            return RedirectToPage("/PickupPoint/Read");
        }
        
    }
}
