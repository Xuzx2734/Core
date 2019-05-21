using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IUserService
    {
        FY_User GetUserByAccount(string userAccount);

        FY_User GetUserById(Guid userGuid);

        IEnumerable<FY_User> GetAllUsers();
    }
}
