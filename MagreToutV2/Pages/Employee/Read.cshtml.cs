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
    public class ReadModel : PageModel {
        [BindProperty]
        public IEnumerable<DemoEmployee> Employees { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        private IEmployee service;

        public ReadModel(IEmployee Service) {
            service = Service;
            
        }
        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Employees = service.GetEmployees(FilterCriteria);
            }
            else
            Employees = service.GetEmployees();
        }
    }
}
