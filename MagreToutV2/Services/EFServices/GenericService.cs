using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;


namespace MalgreToutV2.Services.EFServices {
    public class GenericService : IGenerics {
        private MalgretoutDBContext context;
        public GenericService(MalgretoutDBContext Context) {
            context = Context;
        }
        public void AddAnyObject<T>(T obj) {
            context.Add(obj);
            context.SaveChanges();
        }
        public void DeleteAnyObject<T>(T obj) {
            if (obj != null) {
                context.Remove(obj);
                context.SaveChanges();
            }
        }
    }
}
