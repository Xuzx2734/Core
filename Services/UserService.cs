using Contracts;
using Entities.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Repository;

namespace Services
{
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repoWrapper;
        private KBContext _db;

        public UserService(IRepositoryWrapper repoWrapper, KBContext db)
        {
            _repoWrapper = repoWrapper;
            _db = db;
        }

        public FY_User GetUserByAccount(string userAccount)
        {
            var query = from x in _db.FY_User.Where(x => x.UserAccount == userAccount)
                        select x;
            var user = query.FirstOrDefault();
            return query.FirstOrDefault();
        }
    }
}
