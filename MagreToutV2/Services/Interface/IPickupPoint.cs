using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagreToutV2.Models;


namespace MagreToutV2.Services.Interface
{
    public interface IPickupPoint
    {
        void Update(DemoPickupPoint movie);
        IEnumerable<DemoPickupPoint> GetAllPickupPoints();
        void AddPickupPoint(DemoPickupPoint pickUpPoint);
        void DeletePickupPoint(DemoPickupPoint pickupPoint);
        DemoPickupPoint GetPickupPointById(int PickupPointId);
        DemoPickupPoint GetPickupPoint(int id);
    }   

}
