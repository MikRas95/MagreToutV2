using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagreToutV2.Models;
using MagreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;


namespace MagreToutV2.Services.EFServices
{
    public class ContactPersonService : IContactPerson
    {

        public MagretoutDBContext context;
        public ContactPersonService(MagretoutDBContext Context) {
            context = Context;
        }
        public IEnumerable<DemoContactPerson> GetContactPeople() {
            return context.DemoContactPeople;
        }
       
        public void AddContactPerson(DemoContactPerson ContactPerson)
        {
            context.Add(ContactPerson);
            context.SaveChanges();
        }

        public DemoContactPerson GetContactPerson(int ContactPersonId)
        {
            return context.DemoContactPeople.Find(ContactPersonId);
        }

        public void DeleteContactPerson(DemoContactPerson ContactPerson)
        {
            if (ContactPerson != null)
            {
                context.DemoContactPeople.Remove(ContactPerson);
                context.SaveChanges();  
            }
        }
    }
}
