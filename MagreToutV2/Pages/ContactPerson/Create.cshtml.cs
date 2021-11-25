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
    public class CreateModel : PageModel
    {
        [BindProperty]
        public DemoContactPerson ContactPerson { get; set; }
        IContactPerson ContactPersonService;
        public CreateModel(IContactPerson service)
        {
            this.ContactPersonService = service;
            ContactPerson = new DemoContactPerson();
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ContactPersonService.AddContactPerson(ContactPerson);
            return RedirectToPage(); // Skal have et ordenligt return page nok "GetPickPersons"
            
        }
    }
}
