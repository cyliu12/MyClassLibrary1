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
            SaveObjects saveObjects = new SaveObjects();
            saveObjects.Name = "test01";

            int number1 = 10;
            int number2 = 20;            
            SimpleTest simpleTest = new SimpleTest();
            DateTime now = DateTime.Now;
            saveObjects.AddItem("number1", number1.ToString());
            saveObjects.AddItem("number2", number2.ToString());            
            saveObjects.AddItem("simpleTest", FileIO.ConvertToJsonString(simpleTest));
            saveObjects.AddItem("now", FileIO.ConvertToJsonString(now));

            string fullpath = "./" + saveObjects.Name + saveObjects.SubFilename;

            Console.WriteLine("Saved Contents");
            SaveLoadAppStatus.SaveObjectToFile(saveObjects);
            foreach (var key in saveObjects.Stock.Keys)
            {
                Console.WriteLine("{0} = {1}", key, saveObjects.Stock[key]);
            }            
            
            number1 = 91;
            number2 = 92;
            simpleTest.member1 = "CM1";
            simpleTest.member2 = "CM2";
            now = new DateTime();
            Console.WriteLine("Values Changed");
            Console.WriteLine("{0} = {1}", "number1", number1.ToString());
            Console.WriteLine("{0} = {1}", "number2", number2.ToString());
            Console.WriteLine("{0} = {1}", "simpleTest.Member1", simpleTest.member1);
            Console.WriteLine("{0} = {1}", "simpleTest.Member2", simpleTest.member2);
            Console.WriteLine("{0} = {1}", "now", now.ToString("G"));

            saveObjects = SaveLoadAppStatus.LoadObjectFromFile(fullpath);
            Console.WriteLine("Loaded Contents");            
            foreach (var key in saveObjects.Stock.Keys)
            {
                Console.WriteLine("{0} = {1}", key, saveObjects.Stock[key]);
            }

            number1 = Convert.ToInt32(saveObjects.Stock["number1"]);
            number2 = Convert.ToInt32(saveObjects.Stock["number2"]);
            simpleTest = FileIO.ConvertJsonBackToObj<SimpleTest>(saveObjects.Stock["simpleTest"]);
            now = FileIO.ConvertJsonBackToObj<DateTime>(saveObjects.Stock["now"]);

            Console.WriteLine("Restored Values");
            Console.WriteLine("{0} = {1}", "number1", number1.ToString());
            Console.WriteLine("{0} = {1}", "number2", number2.ToString());
            Console.WriteLine("{0} = {1}", "simpleTest.Member1", simpleTest.member1);
            Console.WriteLine("{0} = {1}", "simpleTest.Member2", simpleTest.member2);
            Console.WriteLine("{0} = {1}", "now", now.ToString("G"));

            Console.ReadLine();
        }

        class SimpleTest 
        {
            public string member1 { get; set; } = "Member1";
            public string member2 { get; set; } = "Member2";
        }


    }
}
