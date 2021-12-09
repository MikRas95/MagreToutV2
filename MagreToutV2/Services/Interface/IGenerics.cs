using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalgreToutV2.Services.Interface {
    public interface IGenerics {
        void AddAnyObject<T>(T obj);
        void DeleteAnyObject<T>(T obj);
    }
}
