using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class UserModelDto : UserModel
    {
        public UserModelDto(FY_User user)
        {
            UserID = user.UserId;
            UserName = user.UserName;
            UserAccount = user.UserAccount;
            OrgId = user.OrgId;
            OrgName = user.OrgName;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
