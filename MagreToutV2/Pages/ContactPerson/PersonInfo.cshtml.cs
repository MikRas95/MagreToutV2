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
    public class PersonInfoModel : PageModel
    {
        [BindProperty]
        public DemoContactPerson ContactPerson { get; set; }
        public IContactPerson service;
        public PersonInfoModel(IContactPerson Service) {
            service = Service;
            ContactPerson = new DemoContactPerson();
        }
        public void OnGet(int id)
        {
            ContactPerson = service.GetContactPerson(id);
        }
    }
}
