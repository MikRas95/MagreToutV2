using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;

namespace MalgreToutV2.Services.Interface
{
    public interface IContactPerson
    {
        IEnumerable<DemoContactPerson> GetContactPeople(string name);
        IEnumerable<DemoContactPerson> GetContactPeople();
        DemoContactPerson GetPickupPointPerson(int id);
        void AddContactPerson(DemoContactPerson ContactPerson);
        DemoContactPerson GetContactPerson(int ContactPersonId);
        void DeleteContactPerson(DemoContactPerson ContactPerson);
        void Update(DemoContactPerson ContactPerson);
    }
}
