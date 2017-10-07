using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Serialization_stud
{

    [Serializable] //Required by BinaryFormatter and SoapFormatter  
    public class Student  //XMLSerializer needs the public class
        {
        public string LastName;
        public string Address;
        public string Code;

        [System.Xml.Serialization.XmlIgnore]   //Ignore in Xml Serialization          
                                               //Public fields are serialize by the three formatters  
        public string FirstName;


        [NonSerialized] //Thield will not be serialized
        public string Nationality;

        //These fields will not be serialized by XmlSerialization

           
        // Create SetAddress(string address, string code) method
        public void SetAddress(string address, string code)
        {

        }
        // Override ToString() method
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
