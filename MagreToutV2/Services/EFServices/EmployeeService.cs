using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;

namespace MalgreToutV2.Services.EFServices
{
    public class EmployeeService : IEmployee
    {
        private MalgretoutDBContext context;
        public EmployeeService(MalgretoutDBContext Context) {
            context = Context;
        }
        public void DeleteEmployee(DemoEmployee employee) {
            if(employee != null) {
                context.DemoEmployees.Remove(employee);
                context.SaveChanges();
            }
        }
        public DemoEmployee GetEmployee(int id) {
            return context.DemoEmployees.Find(id);
        }
    }
}
