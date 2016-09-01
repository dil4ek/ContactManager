using BusinessLogic.DBContextDomain;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public static class AuthenticationServices
    {
        public static User LoggedUser { get; set; }

        public static void AuthenticationUser(string userName, string pass)
        {
            //Stop databse initialization process
            //Database.SetInitializer(new NullDatabaseInitializer<PhoneBookContext>());

            IUserRepository userRepo = new TextUserRepository();
            LoggedUser = userRepo.GetByUserNameAndPassword(userName, pass);

        }
    }
}
