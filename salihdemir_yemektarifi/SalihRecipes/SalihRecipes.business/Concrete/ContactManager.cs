using SalihRecipes.business.Abstract;
using SalihRecipes.data.Abstract;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.business.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactRepository _contactRepository;
        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public void ContactAdd(Contact contact)
        {
            _contactRepository.Create(contact);
        }

        public List<Contact> GetAll()
        {
           return _contactRepository.GetAll();
        }

        public Contact GetContactDetails(int id)
        {
            return _contactRepository.GetContactDetails(id);
        }
    }
}
