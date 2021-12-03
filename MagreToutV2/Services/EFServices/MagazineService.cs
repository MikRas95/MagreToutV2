using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace MalgreToutV2.Services.EFServices
{
    public class MagazineService : IMagazine
    {
        private MalgretoutDBContext context;
        public MagazineService(MalgretoutDBContext Context)
        {
            context = Context;
        }
        public void AddMagazine(DemoMagazine magazine)
        {
            context.DemoMagazines.Add(magazine);
            context.SaveChanges();
        }

        public DemoMagazine GetMagazine(int id)
        {
            return context.DemoMagazines.Find(id);
        }

        // kan godt være den her skal ændres senere for at inclue DemoAd
        public IEnumerable<DemoMagazine> GetMagazines()
        {
            IEnumerable<DemoMagazine> list;
            list = context.DemoMagazines.Where(m => m.VersionId == m.VersionId)
            .AsNoTracking();

            return list;
        }

        public void RemoveMagazine(DemoMagazine magazine)
        {
            if(magazine != null)
            {
                context.DemoMagazines.Remove(magazine);
                context.SaveChanges();
            }
        }

        public void UpdateMagazine(DemoMagazine magazine)
        {
            context.DemoMagazines.Update(magazine);
            context.SaveChanges();
        }
    }
}
