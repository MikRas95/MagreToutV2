using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;

namespace MalgreToutV2.Services.Interface
{
    public interface IAd
    {
        DemoAd GetAd(int id);
        void AddAd(DemoAd ad);
        void RemoveAd(DemoAd ad);
        void UpdateAd(DemoAd ad);
        IEnumerable<DemoAd> GetAds();
    }
}
