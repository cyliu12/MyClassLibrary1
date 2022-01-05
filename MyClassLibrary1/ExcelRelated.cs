using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public static class ExcelRelated
    {
        public static int ColumnLetterToNumber(string letters)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(letters.ToUpper());
            //ASCII VALUE of "A" is 65
            double cc = 0;
            for (var i = 0; i < asciiBytes.Length; i++)
            {
                cc += (asciiBytes[i] - 64) * Math.Pow(26, (asciiBytes.Length - (i + 1)));
            }
            return Convert.ToInt32(cc);
        }
    }
}
