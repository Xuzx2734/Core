using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class UserModel
    {
        public UserModel()
        {
            RoleId = new List<Guid>();
            RoleName = new List<string>();
            ItemCode = new List<string>();
        }

        public Guid UserID { get; set; }
        /// <summary>
        ///账号
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 公司Id
        /// </summary>
        public Guid OrgId { get; set; }
        /// <summary>
        /// 公司名字
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public List<string> RoleName { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public List<Guid> RoleId { get; set; }
        //public List<CS_FunctionConfig> FC { get; set; }
        /// <summary>
        /// 功能点代码
        /// </summary>
        public List<string> ItemCode { get; set; }
        
    }
}
