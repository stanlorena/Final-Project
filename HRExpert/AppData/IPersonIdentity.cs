using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IPersonIdentity
    {
        IEnumerable<PersonIdentity> GetAll();
        PersonIdentity GetById(int personIdentityId);
        void Add(PersonIdentity newPersonIdentity);
        IEnumerable<PersonIdentity> GetPersonIdentityHistory(int id);
    }
}
