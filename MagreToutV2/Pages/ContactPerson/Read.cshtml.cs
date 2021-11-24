using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MagreToutV2.Models;
using MagreToutV2.Services.EFServices;
using MagreToutV2.Services.Interface;

namespace MagreToutV2.Pages.ContactPerson
{
    public class ReadModel : PageModel {
        [BindProperty]
        public IEnumerable<DemoContactPerson> PickupPeople { get; set; }

        private IContactPerson service;

        public ReadModel(IContactPerson Service) {
            service = Service;
            
        }
        public void OnGet()
        {
            PickupPeople = service.GetContactPeople();
        }
    }
}
