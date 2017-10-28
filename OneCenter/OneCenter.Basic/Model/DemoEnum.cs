using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.Basic.Model
{
    public enum DemoEnum
    {
        [Description("Number1")]
        One = 1,

        [Description("Number2")]
        Two = 2
    }
}