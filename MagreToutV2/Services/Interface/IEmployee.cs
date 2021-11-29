using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;

namespace MalgreToutV2.Services.Interface
{
    public interface IEmployee
    {
        public DemoEmployee GetEmployee(int id);
        public void DeleteEmployee(DemoEmployee employee);
    }
}
