using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    interface IPhoneNumberRepository : IGenericRepository<PhoneNumber>
    {
        List<PhoneNumber> GetAll(int contactId);
    }
}
