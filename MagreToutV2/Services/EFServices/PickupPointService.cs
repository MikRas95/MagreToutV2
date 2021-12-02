using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace MalgreToutV2.Services.EFServices
{
    public class PickupPointService : IPickupPoint
    {
        private MalgretoutDBContext context;
        public PickupPointService(MalgretoutDBContext context)
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
        public IEnumerable<DemoPickupPoint> GetPickupPoints(string filter)
        {
            return this.context.Set<DemoPickupPoint>().Where(s => s.Name.StartsWith(filter) || s.Address.Contains(filter))
                .AsNoTracking().ToList();
        }
        public DemoPickupPoint TestMyGETJOIN()
        {
            SELECT  
        }
    }
}