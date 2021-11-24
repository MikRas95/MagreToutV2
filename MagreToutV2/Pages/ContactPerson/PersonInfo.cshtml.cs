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
