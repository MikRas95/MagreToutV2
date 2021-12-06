using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;


namespace MalgreToutV2.Services.EFServices {
    public class LoginService : ILogin {

        private MalgretoutDBContext context;
        public LoginService(MalgretoutDBContext Context) {
            context = Context;
        }
        public bool Login(string username, string password) {
            foreach(DemoEmployee Employee in context.DemoEmployees) {
                if(username == Employee.Username && password == Employee.Password && Employee.Role == "Admin") {
                    return true;
                }
            }
            return false;
        }
    }
}
