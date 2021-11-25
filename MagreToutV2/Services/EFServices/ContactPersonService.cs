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
        private IPickupPoint ppService;
        private MalgretoutDBContext context;

        public ContactPersonService(MalgretoutDBContext Context, IPickupPoint Service) {
            context = Context;
            ppService = Service;
        }
        public IEnumerable<DemoContactPerson> GetContactPeople() {
            IEnumerable<DemoContactPerson> list;
            list = context.DemoContactPeople.Where(m => m.PickupPointId == m.PickupPoint.PickupPointId)
                .Include(m => m.PickupPoint)
                .AsNoTracking();
               
            return list;
        }
       
        public void AddContactPerson(DemoContactPerson ContactPerson)
        {
            context.Add(ContactPerson);
            context.SaveChanges();
        }

        public DemoContactPerson GetContactPerson(int id)
        {
            DemoContactPerson contactPerson = context.DemoContactPeople.Include(m => m.PickupPoint).AsNoTracking().FirstOrDefault(m => m.ContactPersonId == id);


            return contactPerson;
        }

        public void DeleteContactPerson(DemoContactPerson ContactPerson)
        {
            if (ContactPerson != null)
            {
                context.DemoContactPeople.Remove(ContactPerson);
                context.SaveChanges();  
            }
        }
        public void Update(DemoContactPerson ContactPerson)
        {
            context.DemoContactPeople.Update(ContactPerson);
            context.SaveChanges();
        }
    }
}
