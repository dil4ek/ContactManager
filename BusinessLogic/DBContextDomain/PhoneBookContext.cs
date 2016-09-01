using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DBContextDomain
{
    public class PhoneBookContext : DbContext
    {
        static PhoneBookContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<PhoneBookContext>());
        }

        public PhoneBookContext()
            : base("PhoneBook")
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}
