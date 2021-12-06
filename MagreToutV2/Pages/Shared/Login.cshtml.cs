using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MalgreToutV2.Services.Interface;
using MalgreToutV2.Models;
using System.ComponentModel.DataAnnotations;

namespace MalgreToutV2.Pages.Shared
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        ILogin service;
        public LoginModel(ILogin Service) {
            service = Service;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost() {
            if(service.Login(Username, Password)){
                return RedirectToPage("/Index");
            }
            return Page();
            
        }
    }
}
