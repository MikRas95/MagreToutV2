using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using Microsoft.EntityFrameworkCore;


namespace MalgreToutV2.Services.EFServices
{
    public class ContactPersonService : IContactPerson
    {

        public MalgretoutDBContext context;
        public ContactPersonService(MalgretoutDBContext Context) {
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
