using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class PersonIdentityService : IPersonIdentity
    {
        private HrContext _context;

        public PersonIdentityService(HrContext context)
        {
            _context = context;
        }
        public void Add(PersonIdentity newPersonIdentity)
        {
            _context.Add(newPersonIdentity);
            _context.SaveChanges();
        }

        public void Edit(int personIdentityId, long cnp, string serie, int numar, string emitent, DateTime dataEmitere, DateTime dataExpirare)
        {
            var personIdentity = _context.PersonIdentities.FirstOrDefault(p => p.Id == personIdentityId);

            personIdentity.CNP = cnp;
            personIdentity.Serie = serie;
            personIdentity.Numar = numar;
            personIdentity.Emitent = emitent;
            personIdentity.DataEmitere = dataEmitere;
            personIdentity.DataExpirare = dataExpirare;

            _context.SaveChanges();
        }

        public IEnumerable<PersonIdentity> GetAll()
        {
            return _context.PersonIdentities;
        }

        public PersonIdentity GetById(int personIdentityId)
        {
            return _context.PersonIdentities.
                FirstOrDefault(personIdentity => personIdentity.Id == personIdentityId);
        }

        public IEnumerable<PersonIdentity> GetPersonIdentityHistory(int id)
        {
            return _context.PersonIdentities.
                Where(p => p.Persoana.Id == id).
                OrderByDescending(p => p.DataEmitere);
        }

        public void Remove(PersonIdentity newPersonIdentity)
        {
            _context.Remove(newPersonIdentity);
            _context.SaveChanges();
        }
    }
}
