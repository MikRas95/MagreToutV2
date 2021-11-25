using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.ContactPerson
{
    public class UpdateModel : PageModel
    {
        
            [BindProperty]
            public DemoContactPerson PickupPeople { get; set; } = new DemoContactPerson();
            public void OnGet(int ContactPersonId)
            {
                PickupPeople = ContactPersonService.GetContactPerson(ContactPersonId);
            }
            IContactPerson ContactPersonService;
            public UpdateModel(IContactPerson service)
            {
                this.ContactPersonService = service;
            }
            public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                ContactPersonService.Update(PickupPeople);
                return RedirectToPage("/ContactPerson/Read");
            }
        
    }
}
