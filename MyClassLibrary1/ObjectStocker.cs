using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public static class ObjectStocker
    {      
        public static void SaveObjectToFile(Inventory obj)
        {
            FileIO.WriteToBinaryFile("./" + obj.Name + obj.SubFilename, obj);
        }

        public static Inventory LoadObjectFromFile(string fullPath)
        {
            return FileIO.ReadFromBinaryFile<Inventory>(fullPath);
        }

    }

    [Serializable()]
    public class Inventory
    {
        
        private Dictionary<string,string> _objects = new Dictionary<string, string>();

        public Dictionary<string,string> Objects
        {
            get { return _objects; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _subfilename = ".inv";

        public string SubFilename
        {
            get { return _subfilename; }
            set { _subfilename = value; }
        }


        public void AddItem(string name, string valueString)
        {
            

            string val;
            if (_objects.TryGetValue(name, out val))
            {
                // yay, value exists!
                _objects[name] = valueString;
            }
            else
            {
                // darn, lets add the value
                _objects.Add(name, valueString);
            }
        }
       

    }
}
