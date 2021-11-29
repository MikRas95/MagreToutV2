using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MalgreToutV2.Pages.Employee
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public DemoEmployee Employee { get; set; }
        
        IEmployee EmployeeService;
       
        public CreateModel(IEmployee employeeService)
        {
            EmployeeService = employeeService;
        }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                //Employees = EmployeeService.GetAllPickupPoints();
                return Page();
            }
            EmployeeService.AddEmployee(Employee);
            return RedirectToPage("/Index");

        }
    }
}
