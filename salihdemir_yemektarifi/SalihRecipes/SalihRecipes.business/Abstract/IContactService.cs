using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.business.Abstract
{
    public interface IContactService
    {
        void ContactAdd(Contact contact);
        List<Contact> GetAll();
        Contact GetContactDetails(int id);
    }
}
