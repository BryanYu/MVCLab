using OneCenter.DAL.DAL;
using OneCenter.Models.ViewModels.Admin;
using OneCenter.Utility.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.BLL.Admin
{
    /// <summary>
    /// AdminService
    /// </summary>
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

        /// <summary>
        /// 新增管理員
        /// </summary>
        /// <param name="model"></param>
        public void AddAdmin(AdminViewModel model)
        {
            /// Password 應該是要經過加密 不可以用明碼存
            model.Password = Cryptography.GetMd5Hash(model.Password);
            this._dal.Insert(model.Account, model.Password, model.Name);
        }
    }
}