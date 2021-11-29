using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Pages.Employee
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public DemoEmployee Employee { get; set; } = new DemoEmployee();
        IEmployee employeeService;

        public void OnGet(int EmployeeId)
        {
            Employee = employeeService.GetEmployee(EmployeeId);
        }

        public UpdateModel(IEmployee service)
        {
            this.employeeService = service;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            employeeService.UpdateEmployee(Employee);
            return RedirectToPage("/Employee/Read");
        }

    }
}
