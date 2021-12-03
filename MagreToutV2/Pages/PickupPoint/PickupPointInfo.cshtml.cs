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
        public DemoContactPerson contactPerson { get; set; }
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; }
        public IContactPerson cService;
        public IPickupPoint service;
        public PickupPointInfoModel(IPickupPoint Service, IContactPerson Service2)
        {
            cService = Service2;
            service = Service;
            PickupPoint = new DemoPickupPoint();
            contactPerson = new DemoContactPerson();
        }
        public void OnGet(int id)
        {
            PickupPoint = service.GetPickupPoint(id);
            contactPerson = cService.GetPickupPointPerson(id);
        }
    }
}
