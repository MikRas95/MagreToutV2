using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MalgreToutV2.Pages.Employee
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public DemoEmployee Employee { get; set; }
        IEmployee service;
        public DeleteModel(IEmployee Service) {
            service = Service;
        }
        public void OnGet(int EmployeeId)
        {
            Employee = service.GetEmployee(EmployeeId);
        }
        public IActionResult OnPost() {
            service.DeleteEmployee(Employee);
            return RedirectToPage("Read");
        }
    }
}
