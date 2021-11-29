using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.ContactPerson
{
    public class ReadModel : PageModel {
        [BindProperty]
        public IEnumerable<DemoContactPerson> PickupPeople { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        private IContactPerson service;

        public ReadModel(IContactPerson Service) {
            service = Service;
        }
        public void OnGet()
        {
            PickupPeople = service.GetContactPeople(FilterCriteria);
        }
    }
}
