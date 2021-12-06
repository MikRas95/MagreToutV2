using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalgreToutV2.Services.Interface {
    public interface ILogin {
        bool Login(string username, string password);
    }
}
