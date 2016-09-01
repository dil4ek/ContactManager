using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByUserNameAndPassword(string userName, string password);
    }
}
