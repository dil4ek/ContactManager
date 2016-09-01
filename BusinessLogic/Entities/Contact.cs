using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public List<PhoneNumber> PhoneNumber { get; set; }

        public Contact()
        {
            PhoneNumber = new List<PhoneNumber>();
        }

        public override string ToString()
        {
            return Firstname + " " + LastName;
        }
    }
}
