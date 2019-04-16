using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Entities.Models
{
    [Table("FY_User")]
    public class FY_User
    {
        public FY_User() {
            this.IsVaild = 255;
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public Guid UserId { get; set; }
        /// <summary>
        /// 用户名/学员名
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 用户(学员)登录账号
        /// </summary>
        [Required]
        public string UserAccount { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required]
        public string Gender { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 部门Id
        /// </summary>
        public Guid OrgId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 公司Id
        /// </summary>
        public Guid CompanyId { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 员工类型，1为员工，2外部用户
        /// </summary>
        [Required]
        public int EmployeeType { get; set; }
        /// <summary>
        /// 1:是删除0：不是
        /// </summary>
        public int DelFlag { get; set; }
        /// <summary>
        /// 是否停用，0为停用，1为有效
        /// </summary>
        public int IsVaild { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 达标标准
        /// </summary>
        public string PassStandard { get; set; }
        /// <summary>
        /// 登陆次数
        /// </summary>
        public int LoginNum { get; set; }
        /// <summary>
        /// 最后一次登陆时间
        /// </summary>
        public DateTime? LastDate { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public Guid? CreateUser { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 显示类型 0：日历  1：列表
        /// </summary>
        public int? ShowType { get; set; }

        [NotMapped]
        public string OrgIdStr { get; set; }

        public string OaId { get; set; }
        /// <summary>
        /// 办公电话
        /// </summary>
        public string OfficePhone { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        [NotMapped]
        public string NPWD { get; set; }
        /// <summary>
        /// 确认密码
        /// </summary>
        [NotMapped]
        public string CPWD { get; set; }
        [NotMapped]
        public string sort { get; set; }
        [NotMapped]
        public string order { get; set; }
    }
}

