using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public static class StringExt
    {
        static public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
