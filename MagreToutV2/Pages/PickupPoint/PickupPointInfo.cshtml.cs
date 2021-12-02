using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using MalgreToutV2.Services.EFServices;
using Microsoft.EntityFrameworkCore;

namespace MalgreToutV2.Pages.PickupPoint
{
    public class PickupPointInfoModel : PageModel
    {
        [BindProperty]
        public DemoPickupPoint PickupPoint { get; set; }
        [BindProperty]
        public DemoContactPerson ContactPerson { get; set; }
        public IPickupPoint service;
        public IContactPerson CPservice;
        public PickupPointInfoModel(IPickupPoint Service, IContactPerson contactPerson)
        {
            CPservice = contactPerson;
            service = Service;
            PickupPoint = new DemoPickupPoint();
            ContactPerson = new DemoContactPerson();
        }
        public void OnGet(int id)
        {
            //PickupPoint = service.GetPickupPoint(id);
            ContactPerson = CPservice.testGet(id);
        }

    }
}
