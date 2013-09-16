using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    public class MySerializer
    {
        public MySerializer() { }

        public void SerializeObject(string fileName, ManagerStudent objToSerialize)
        {
            FileStream fstream = File.Open(fileName, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fstream, objToSerialize);
            fstream.Close();
        }

        public ManagerStudent DeserializeObject(string fileName)
        {
            ManagerStudent objToSerialize = null;
            FileStream fstream = File.Open(fileName, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            objToSerialize = (ManagerStudent)binaryFormatter.Deserialize(fstream);
            fstream.Close();
            return objToSerialize;
        }
    } 
}
