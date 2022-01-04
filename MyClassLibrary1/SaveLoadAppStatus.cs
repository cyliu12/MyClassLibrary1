using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public static class SaveLoadAppStatus
    {
        public static void tester()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();

        }
    }

    [Serializable()]
    public class SaveObjects
    {
        private static Dictionary<string,string> _stock;

        public Dictionary<string,string> Stock
        {
            get { return _stock; }
        }


        public static void AddItem(string name, string valueString)
        {
            _stock.Add(name, valueString);
        }
       

    }
}
