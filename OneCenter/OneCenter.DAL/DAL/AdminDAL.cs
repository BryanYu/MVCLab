using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.DAL.DAL
{
    /// <summary>
    /// Admin資料存取
    /// </summary>
    public class AdminDAL
    {
        /// <summary>
        /// DbContext
        /// </summary>
        private OneCenterEntities _db;

        /// <summary>
        /// Contructor
        /// </summary>
        public AdminDAL()
        {
            this._db = new OneCenterEntities();

            ///可以開啟LINQ TO SQL 紀錄查詢SQL語法，在偵錯及LINQ調教上非常好用
            this._db.Database.Log = (arg) => Debug.Write(arg);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="account">帳號</param>
        /// <param name="password">密碼</param>
        /// <param name="name">名稱</param>
        public void Insert(string account, string password, string name)
        {
            var entity = new Admin
            {
                Account = account,
                Password = password,
                Name = name,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            this._db.Admin.Add(entity);

            ///需要執行SaveChanges 才會對資料庫執行操作
            this._db.SaveChanges();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id">序號</param>
        /// <param name="account">帳號</param>
        /// <param name="password">密碼</param>
        /// <param name="name">名稱</param>
        public void Update(int id, string account = "", string password = "", string name = "")
        {
            var entity = this._db.Admin.FirstOrDefault(item => item.Id == id);
            if (entity == null)
            {
                throw new ArgumentException("找不到使用者");
            }
            entity.Account = account == string.Empty ? entity.Account : account;
            entity.Password = password == string.Empty ? entity.Password : password;
            entity.Name = name == string.Empty ? entity.Name : name;
            entity.UpdateDate = DateTime.Now;

            ///需要執行SaveChanges 才會對資料庫執行操作
            this._db.SaveChanges();
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id">序號</param>
        public void Delete(int id)
        {
            var entity = this._db.Admin.FirstOrDefault(item => item.Id == id);
            if (entity == null)
            {
                throw new ArgumentException("找不到使用者");
            }
            this._db.Admin.Remove(entity);

            ///需要執行SaveChanges 才會對資料庫執行操作
            this._db.SaveChanges();
        }

        /// <summary>
        /// 取得一筆
        /// </summary>
        /// <param name="id">序號</param>
        /// <returns></returns>
        public Admin GetAdmin(int id)
        {
            var entity = this._db.Admin.FirstOrDefault(item => item.Id == id);
            return entity;
        }

        /// <summary>
        /// 取得Admin列表
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public IEnumerable<Admin> GetAdmins(Func<Admin, bool> func)
        {
            ///AsNoTracking 可以將EF查詢出來的物件不加入追蹤
            ///在做大量資料操作時可以節省效能(例如：一次性報表、進快取的參考資料)
            ///this._db.Admin.AsNoTracking().Where(func);

            ///Include("關聯資料表名稱")
            ///可以將該資料的關聯資料一次全部載入，可以避免當使用關聯資料時，連續查詢資料庫的問題
            ///this._db.Admin.Include("Schedule").Where(func);
            var entities = this._db.Admin.Where(func);
            return entities;
        }
    }
}