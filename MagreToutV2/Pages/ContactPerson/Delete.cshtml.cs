using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Services.Interface;
using MalgreToutV2.Models;

namespace MalgreToutV2.Pages.ContactPerson
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public DemoContactPerson ContactPerson { get; set; }
        IContactPerson Service;
        public DeleteModel(IContactPerson service)
        {
            this.Service = service;
        }

        public void OnGet(int ContactPersonId)
        {
            ContactPerson = Service.GetContactPerson(ContactPersonId);
        }

        public IActionResult OnPost()
        {
            Service.DeleteContactPerson(ContactPerson);
            return RedirectToPage("read");
        }
    }
}
