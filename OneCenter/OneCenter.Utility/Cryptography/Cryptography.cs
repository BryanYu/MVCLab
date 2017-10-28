using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.Utility.Cryptography
{
    /// <summary>
    /// 加密演算法工具類別
    /// </summary>
    public static class Cryptography
    {
        /// <summary>
        /// 取得MD5雜湊字串
        /// </summary>
        /// <param name="input">輸入字串</param>
        /// <returns>MD5雜湊字串</returns>
        public static string GetMd5Hash(string input)
        {
            using (var md5Hash = MD5.Create())
            {
                var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("x2"));
                }

                return builder.ToString().ToUpper();
            }
        }
    }
}