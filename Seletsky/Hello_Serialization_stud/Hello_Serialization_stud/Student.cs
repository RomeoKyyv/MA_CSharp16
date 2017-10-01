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
        [System.Xml.Serialization.XmlIgnore]   //Ignore in Xml Serialization          
                                               //Public fields are serialize by the three formatters  
        public string FirstName;
        public string LastName;

        [NonSerialized] //Thield will not be serialized

        //These fields will not be serialized by XmlSerialization

        public string Nationality;
        private string Address;
        private string Code;

        // Create SetAddress(string address, string code) method
        public void SetAddress(string address , string code)
        {
            Address = address;
            Code = code;
        }
        // Override ToString() method
        public override string ToString()
        {
            Console.WriteLine(this.FirstName);
            return base.ToString();
        }
    }  
    
}
