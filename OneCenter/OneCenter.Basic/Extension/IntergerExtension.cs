using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.Basic.Extension
{
    /// <summary>
    /// int擴充方法
    /// </summary>
    public static class IntergerExtension
    {
        public static int GetNextNumber(this int arg)
        {
            return arg + 1;
        }

        public static int GetMutiple(this int arg, int arg2)
        {
            return arg * arg2;
        }
    }
}