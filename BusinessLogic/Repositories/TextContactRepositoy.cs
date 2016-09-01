using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DBContextDomain;
using System.Data.Entity;

namespace BusinessLogic.Repositories
{
    public class TextContactRepositoy : IContactsRepository
    {
        private Contact contact = new Contact();

        public List<Contact> GetAll(int userID)
        {
            List<Contact> contacts = new List<Contact>();
            using (var context = new PhoneBookContext())
            {
                contacts = context.Contacts.Where(x => x.UserId == userID).ToList(); 
            }

            return contacts;
        }

        public Contact GetById(int id)
        {
            using (var context = new PhoneBookContext())
            {
                contact = context.Contacts.Where(x => x.Id == id).FirstOrDefault();
            }

            return contact;
        }

        public List<Contact> GetAll()
        {
            List<Contact> contacts = new List<Contact>();
            using (var context = new PhoneBookContext())
            {
                contacts = context.Contacts.ToList();
            }
            return contacts;
        }

        public void Add(Contact item)
        {
            contact.Firstname = item.Firstname;
            contact.LastName = item.LastName;
            contact.UserId = item.UserId;

            using (var context = new PhoneBookContext())
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
            }
        }

        public void Update(Contact item)
        {
            contact = GetById(item.Id);

            if (contact != null)
            {
                contact.Firstname = item.Firstname;
                contact.LastName = item.LastName;
            }
            else
            {
                throw new ArgumentNullException("Please choose contact to update");
            }

            using (var context = new PhoneBookContext())
            {
                context.Contacts.Attach(contact);
                context.Entry(contact).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Contact item)
        {
            contact = GetById(item.Id);

            if (contact == null)
            {
                throw new ArgumentNullException("Please choose contact to delete");
            }

            using (var context = new PhoneBookContext())
            {
                context.Contacts.Attach(contact);
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
        }
    }
}
