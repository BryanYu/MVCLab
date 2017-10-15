using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.Utiltiy.Extension
{
    /// <summary>
    /// 列舉擴充方法
    /// https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
    /// </summary>
    public static class EnumExtension
    {
        public static string GetDescription(this Enum type)
        {
            FieldInfo fi = type.GetType().GetField(type.ToString());
            var attributes = fi.GetCustomAttribute(typeof(DescriptionAttribute), false)
                                    as DescriptionAttribute;
            if (attributes != null)
            {
                return attributes.Description;
            }

            return type.ToString();
        }
    }
}