using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagreToutV2.Models;
using MagreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace MagreToutV2.Services.EFServices
{
    public class PickupPointService : IPickupPoint
    {
        private MagretoutDBContext context;
        public PickupPointService(MagretoutDBContext context)
        {
            this.context = context;
        }
        
        public void Update(DemoPickupPoint pickupPoint)
        {
            context.DemoPickupPoints.Update(pickupPoint);
            context.SaveChanges();
        }

        public DemoPickupPoint GetPickupPoint(int id)
        {
            DemoPickupPoint pickupPoint = context.Set<DemoPickupPoint>()
                .Include(m => m.DemoContactPeople)
                .AsNoTracking()
                .FirstOrDefault(m => m.PickupPointId == id);
            return pickupPoint;
        }
        public void AddPickupPoint(DemoPickupPoint pickUpPoint) {
            context.Add(pickUpPoint);
            context.SaveChanges();
        }

        public void DeletePickupPoint(DemoPickupPoint pickupPoint)
        {
            if (pickupPoint != null)
            {
                context.DemoPickupPoints.Remove(pickupPoint);
                context.SaveChanges();
            }
        }

        public IEnumerable<DemoPickupPoint> GetAllPickupPoints()
        {
            return context.DemoPickupPoints;
        }


        public DemoPickupPoint GetPickupPointById(int PickupPointId)
        {
            return context.DemoPickupPoints.Find(PickupPointId);
        }
    }
}