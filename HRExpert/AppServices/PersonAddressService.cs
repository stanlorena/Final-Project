using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class PersonAddressService : IPersonAddress
    {
        private HrContext _context;

        public PersonAddressService(HrContext context)
        {
            _context = context;
        }
        public void Add(PersonAddress newPersonAddress)
        {
            _context.Add(newPersonAddress);
            _context.SaveChanges();
        }

        public IEnumerable<PersonAddress> GetAll()
        {
            return _context.PersonAddresses;
        }

        public PersonAddress GetById(int id)
        {
            return _context.PersonAddresses
                .FirstOrDefault(personAddress => personAddress.Id == id);
        }

        public IEnumerable<PersonAddress> GetPersonAddressHistory(int id)
        {
            return _context.PersonAddresses
                 .Where(p => p.Persoana.Id == id)
                 .OrderByDescending(p => p.DataInceput);
        }
    }
}
