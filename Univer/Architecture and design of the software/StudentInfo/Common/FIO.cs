using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Common
{
    [Serializable]
    public class FIO : ISerializable
    {
        public FIO() { }

        public FIO(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get ; set ;}
        public string LastName { get ; set ; }


        public FIO(SerializationInfo sInfo, StreamingContext contextArg)
        {
            this.FirstName = (string)sInfo.GetValue("FirstName", typeof(string));
            this.LastName = (string)sInfo.GetValue("SecondName", typeof(string));
        }

        public void GetObjectData(SerializationInfo sInfo, StreamingContext contextArg)
        {
            sInfo.AddValue("FirstName", this.FirstName);
            sInfo.AddValue("SecondName", this.LastName);
        }
    }
}
