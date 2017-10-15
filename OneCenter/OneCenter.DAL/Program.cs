using OneCenter.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.DAL
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adminDal = new AdminDAL();

            Console.WriteLine("示範Entity Framework 如何對資料庫進行新增、修改、查詢、刪除");
            Console.WriteLine("請按Enter繼續");
            Console.Read();
            Console.WriteLine("新增一筆資料 請按Enter繼續");
            Console.Read();
            adminDal.Insert("Bryan", "123456", "BryanYu");
            Console.WriteLine("新增完成");
            Console.WriteLine("==============================================");
            Console.WriteLine("查詢剛剛那筆資料 請按Enter繼續");
            Console.Read();
            Console.WriteLine($"剛剛新增的資料為：");
            var entity = adminDal.GetAdmins(item => item.Account == "Bryan").FirstOrDefault();
            Console.WriteLine($"帳號：{entity.Account}");
            Console.WriteLine($"密碼：{entity.Password}");
            Console.WriteLine($"姓名：{entity.Name}");
            Console.WriteLine($"建立時間：{entity.CreateDate}");
            Console.WriteLine($"修改時間：{entity.UpdateDate}");
            Console.WriteLine("==============================================");
            Console.Read();
            Console.WriteLine("修改一筆資料 請按Enter繼續");

            Console.Read();
            adminDal.Update(entity.Id, name: "BryanYu123456");
            Console.WriteLine("修改完成");

            Console.WriteLine($"帳號：{entity.Account}");
            Console.WriteLine($"密碼：{entity.Password}");
            Console.WriteLine($"姓名：{entity.Name}");
            Console.WriteLine($"建立時間：{entity.CreateDate}");
            Console.WriteLine($"修改時間：{entity.UpdateDate}");
            Console.WriteLine("==============================================");
            Console.WriteLine("刪除一筆資料 請按Enter繼續");
            Console.Read();
            Console.Read();
            adminDal.Delete(entity.Id);
            Console.WriteLine("刪除完成");
        }
    }
}