using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;

namespace MalgreToutV2.Services.Interface
{
    public interface IEmployee
    {
        DemoEmployee GetEmployee(int id);
        void DeleteEmployee(DemoEmployee employee);
        void AddEmployee(DemoEmployee Employee);
        void UpdateEmployee(DemoEmployee employee);
        IEnumerable<DemoEmployee> GetEmployees();
        IEnumerable<DemoEmployee> GetEmployees(string filter);
    }
}
