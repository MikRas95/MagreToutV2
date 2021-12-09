using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;


namespace MalgreToutV2.Services.Interface
{
    public interface IPickupPoint
    {
        void Update(DemoPickupPoint pickupPoint);
        IEnumerable<DemoPickupPoint> GetAllPickupPoints();
        void AddPickupPoint(DemoPickupPoint pickupPoint);
        void DeletePickupPoint(DemoPickupPoint pickupPoint);
        DemoPickupPoint GetPickupPointById(int PickupPointId);
        DemoPickupPoint GetPickupPoint(int id);
        IEnumerable<DemoPickupPoint> GetPickupPoints(string filter);
    }   

}
