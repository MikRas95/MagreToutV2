using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using MalgreToutV2.Services.EFServices;

namespace MalgreToutV2.Pages.PickupPoint
{
    public class PickupPointInfoModel : PageModel
    {
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; }
        public IPickupPoint service;
        public PickupPointInfoModel(IPickupPoint Service)
        {
            service = Service;
            PickupPoint = new DemoPickupPoint();
        }
        public void OnGet(int id)
        {
            PickupPoint = service.GetPickupPoint(id);
        }
    }
}
