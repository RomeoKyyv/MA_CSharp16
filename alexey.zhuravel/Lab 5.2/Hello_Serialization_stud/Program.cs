using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Hello_Serialization_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of Student class
            Student student = new Student();
            // Initialize its properties
            student.Address = "Kharkov";
            student.FirstName = "Vasya";
            student.LastName = "Ivanov";
            student.Nationality = "ukr";
            student.Code = "223322";
            // Call methods for serialization and deserialization

            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fStream = new FileStream(@"E:\1.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, student);

            }


            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = new FileStream(@"E:\1.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, student);

            }

            using (Stream fStream = File.OpenRead(@"E:\1.dat"))
            {
                Student stud = (Student)binFormat.Deserialize(fStream);
                Console.WriteLine(stud.Code);
            }
        }

        // Impement BinaryFrm(Student p) method to serialize and deserialize p
        public void BinaryFrm(Student p)
        {

        }


        // Define path for file
        string path = @"E:/";
        // Implement BinaryFormatter object creation and p serialization  in using block for FileStream object

        // Implement BinaryFormatter object creation and  deserialization  in using block for FileStream object
        // Write deserialization result to console

        // Impement SoapFrm(Student p) method to serialize and deserialize p
        public void SoapFrm(Student p)
        {

        }


        // Define path for file
        // Implement SoapFormatter object creation and p serialization  in using block for FileStream object

        // Implement SoapFormatter object creation and  deserialization  in using block for FileStream object
        // Write deserialization result to console

        // Impement XmlFrm(Student p) method to serialize and deserialize p 
        public void XmlFrm(Student p)
        {

        }
        // Define path for file

        // Create XmlSerializer serializer typeof Student       
        // Implement  p serialization  in using block for FileStream object

        // Create XmlSerializer deserializer typeof Student 
        // Implement   deserialization  in using block for FileStream object
        // Write deserialization result to console

    }
}

