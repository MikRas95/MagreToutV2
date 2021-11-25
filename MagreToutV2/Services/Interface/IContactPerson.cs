using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalgreToutV2.Models;

namespace MalgreToutV2.Services.Interface
{
    public interface IContactPerson
    {
        public IEnumerable<DemoContactPerson> GetContactPeople();
        void AddContactPerson(DemoContactPerson ContactPerson);
        DemoContactPerson GetContactPerson(int ContactPersonId);
        void DeleteContactPerson(DemoContactPerson ContactPerson);
    }
}
