using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;


namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveLoadAppStatus.tester();
            SaveObjects saveObjects = new SaveObjects();
            SaveObjects.AddItem("number1", "10");
            Console.WriteLine(aveObjects.Stock["number1"]);
            Console.ReadLine();
        }
    }
}
