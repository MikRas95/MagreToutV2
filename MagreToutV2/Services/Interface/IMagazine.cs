using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;

namespace MalgreToutV2.Services.Interface
{
    public interface IMagazine
    {
        DemoMagazine GetMagazine(int id);
        void AddMagazine(DemoMagazine magazine);
        void RemoveMagazine(DemoMagazine magazine);
        void UpdateMagazine(DemoMagazine magazine);
        IEnumerable<DemoMagazine> GetMagazines();
    }
}
