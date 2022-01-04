using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public static class SaveLoadAppStatus
    {      
        public static void SaveObjectToFile(SaveObjects obj)
        {
            FileIO.WriteToBinaryFile("./" + obj.Name + obj.SubFilename, obj);
        }

        public static SaveObjects LoadFileToFile(string fullPath)
        {
            return FileIO.ReadFromBinaryFile<SaveObjects>(fullPath);
        }

    }

    [Serializable()]
    public class SaveObjects
    {
        
        private Dictionary<string,string> _stock = new Dictionary<string, string>();

        public Dictionary<string,string> Stock
        {
            get { return _stock; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _subfilename = ".sta";

        public string SubFilename
        {
            get { return _subfilename; }
            set { _subfilename = value; }
        }


        public void AddItem(string name, string valueString)
        {
            _stock.Add(name, valueString);
        }
       

    }
}
