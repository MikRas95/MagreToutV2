using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.EFServices;
using MalgreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;

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
        public void AddEmployee(DemoEmployee Employee)
        {
            context.Add(Employee);
            context.SaveChanges();
        }
        public void UpdateEmployee(DemoEmployee employee)
        {
            context.DemoEmployees.Update(employee);
            context.SaveChanges();
        }
        public IEnumerable<DemoEmployee> GetEmployees()
        {
            IEnumerable<DemoEmployee> list;
            list = context.DemoEmployees.Where(m => m.EmployeeId == m.EmployeeId)
            .AsNoTracking();

            return list;
        }
    }
}
