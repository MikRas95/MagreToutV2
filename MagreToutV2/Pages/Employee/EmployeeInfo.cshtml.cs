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
    public class EmployeeInfoModel : PageModel
    {
        [BindProperty]
        public DemoEmployee Employee { get; set; }
        public IEmployee service;
        public EmployeeInfoModel(IEmployee Service)
        {
            service = Service;
            Employee = new DemoEmployee();
        }
        public void OnGet(int id)
        {
            Employee = service.GetEmployee(id);
        }
    }
}
