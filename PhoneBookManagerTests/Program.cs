using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Services;
using BusinessLogic.Repositories;
using BusinessLogic.Entities;

namespace PhoneBookManagerTests
{
    class Program
    {
        static void Main()
        {
            //AuthenticationServices.AuthenticationUser("didi", "333");

            TextUserRepository userRepo = new TextUserRepository();
            //userRepo.GetAll();

            //User user = new User()
            //{
            //    UserName = "test",
            //    Password = "555",
            //    FirstName = "Test",
            //    LastName = "Test"
            //};

            //userRepo.Add(user);

            User user1 = userRepo.GetById(2);

            Contact contact = new Contact()
            {
                Firstname = "Contact 01",
                LastName = "Contact 01",
                UserId = user1.Id
            };

            TextContactRepositoy contactRepo = new TextContactRepositoy();
            contactRepo.Add(contact);

           // user.LastName = "Petakova";

            //userRepo.Update(user);
            //try
            //{
            //    userRepo.Delete(user1);
            //}
            //catch (ArgumentNullException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //List<User> userList = userRepo.GetAll();

            //foreach (var item in userList)
            //{
            //    Console.WriteLine(item.FirstName + " " +item.LastName);
                
            //}

        }
    }
}
