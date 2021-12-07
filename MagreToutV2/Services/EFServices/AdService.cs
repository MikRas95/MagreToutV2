﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace MalgreToutV2.Services.EFServices
{
    public class AdService : IAd
    {
        private MalgretoutDBContext context;
        public AdService(MalgretoutDBContext Context)
        {
            context = Context;
        }
        public void AddAd(DemoAd ad)
        {
            context.DemoAds.Add(ad);
            context.SaveChanges();
        }

        public DemoAd GetAd(int id)
        {
            return context.DemoAds.Find(id);
        }

        // kan godt være den her skal ændres senere for at inclue DemoAd
        public IEnumerable<DemoAd> GetAds()
        {
            IEnumerable<DemoAd> list;
            list = context.DemoAds.Where(m => m.AdId == m.AdId)
            .AsNoTracking();

            return list;
        }

        public void RemoveAd(DemoAd ad)
        {
            if (ad != null)
            {
                context.DemoAds.Remove(ad);
                context.SaveChanges();
            }
        }

        public void UpdateAd(DemoAd ad)
        {
            context.DemoAds.Update(ad);
            context.SaveChanges();
        }
    }
}