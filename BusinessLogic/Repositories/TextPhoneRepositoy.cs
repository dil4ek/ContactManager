using BusinessLogic.DBContextDomain;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repositories
{
    public class TextPhoneRepositoy : IPhoneNumberRepository
    {
        PhoneNumber phoneNumber = new PhoneNumber();

        public List<PhoneNumber> GetAll(int contactId)
        {
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
            using (var context = new PhoneBookContext())
            {
                phoneNumbers = context.PhoneNumbers.Where(x => x.ContactId == contactId).ToList();
            }
            return phoneNumbers;
        }

        public PhoneNumber GetById(int id)
        {
            using (var context = new PhoneBookContext())
            {
                phoneNumber = context.PhoneNumbers.Where(x => x.Id == id).FirstOrDefault();               
            }

            return phoneNumber;
        }

        public List<PhoneNumber> GetAll()
        {
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
            using (var context = new PhoneBookContext())
            {
                phoneNumbers = context.PhoneNumbers.ToList();    
            }

            return phoneNumbers;
        }

        public void Add(PhoneNumber item)
        {
            phoneNumber.Number = item.Number;
            phoneNumber.ContactId = item.ContactId;

            using (var context = new PhoneBookContext())
            {
                context.PhoneNumbers.Add(phoneNumber);
                context.SaveChanges();
            }
        }

        public void Update(PhoneNumber item)
        {
            phoneNumber = GetById(item.Id);

            if (phoneNumber != null)
            {
                phoneNumber.Number = item.Number;
            }
            else
            {
                throw new ArgumentNullException("Please choose phone number to update");
            }

            using (var context = new PhoneBookContext())
            {
                context.PhoneNumbers.Attach(phoneNumber);
                context.Entry(phoneNumber).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(PhoneNumber item)
        {
            phoneNumber = GetById(item.Id);

            if (phoneNumber == null)
            {
                throw new ArgumentNullException("Please choose phone number to delete");
            }

            using (var context = new PhoneBookContext())
            {
                context.PhoneNumbers.Attach(phoneNumber);
                context.PhoneNumbers.Remove(phoneNumber);
                context.SaveChanges();
            }
        }
    }
}
