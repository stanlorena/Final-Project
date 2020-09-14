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
        void Remove(PersonIdentity newPersonIdentity);
        void Edit(int personIdentityId, long cnp, string serie, int numar, string emitent, DateTime dataEmitere, DateTime dataExpirare);
        IEnumerable<PersonIdentity> GetPersonIdentityHistory(int id);
    }
}
