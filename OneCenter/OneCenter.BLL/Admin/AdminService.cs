using OneCenter.DAL.DAL;
using OneCenter.Models.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.BLL.Admin
{
    public class AdminService
    {
        /// <summary>
        /// AdminDAL
        /// </summary>
        private AdminDAL _dal;

        /// <summary>
        /// AdminService Constructor
        /// </summary>
        public AdminService()
        {
            this._dal = new AdminDAL();
        }

        /// <summary>
        /// 取得所有管理者
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AdminViewModel> GetAdmins()
        {
            var admins = this._dal.GetAdmins();
            var result = new List<AdminViewModel>();
            foreach (var admin in admins)
            {
                result.Add(new AdminViewModel
                {
                    Id = admin.Id,
                    Account = admin.Account,
                    Name = admin.Name,
                    Password = admin.Password
                });
            }
            return result;
        }
    }
}