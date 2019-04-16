using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IUserService
    {
        FY_User GetUserByAccount(string userAccount);

    }
}
