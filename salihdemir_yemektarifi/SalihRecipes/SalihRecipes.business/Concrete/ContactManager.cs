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
        private readonly IUnitOfWork _unitOfWork;
        public ContactManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void ContactAdd(Contact contact)
        {
            _unitOfWork.Contacts.Create(contact);
            _unitOfWork.Save();
        }

        public List<Contact> GetAll()
        {
           return _unitOfWork.Contacts.GetAll();
        }

        public Contact GetContactDetails(int id)
        {
            return _unitOfWork.Contacts.GetContactDetails(id);
        }
    }
}
