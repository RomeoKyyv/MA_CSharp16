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
            Student One = new Student();
            // Initialize its properties
            One.FirstName = "JustName";
            One.LastName = "JustSename";
            One.Nationality = "OfUnivers";
            One.SetAddress("Univers", "030303");
            // Call methods for serialization and deserialization
            BinaryFrm(One);
            Console.ReadKey();
            SoapFrm(One);
            Console.ReadKey();
            XmlFrm(One);
            Console.ReadKey();
        }

        // Impement BinaryFrm(Student p) method to serialize and deserialize p
        static public void BinaryFrm(Student p)
        {        // Define path for file
            string FileName = @"D:\\testlab2.bin";
            Student student = new Student();
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.Nationality);

            Console.WriteLine("********************************");
            // Implement BinaryFormatter object creation and p serialization  in using block for FileStream object
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream newStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None)) 
            {
                binaryFormatter.Serialize(newStream, p);
            }
            // Implement BinaryFormatter object creation and  deserialization  in using block for FileStream object
            using (Stream readStream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
               student = (Student)binaryFormatter.Deserialize(readStream);
            }
            // Write deserialization result to console
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Nationality);

        }


        // Impement SoapFrm(Student p) method to serialize and deserialize p
        static public void SoapFrm(Student p)
        {
            string FileName = @"D:\\testlabFOAM.bin";
            Student student = new Student();
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.Nationality);

            Console.WriteLine("********************************");
            // Implement BinaryFormatter object creation and p serialization  in using block for FileStream object
            SoapFormatter SoapFormatter = new SoapFormatter();
            using (Stream newStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                SoapFormatter.Serialize(newStream, p);
            }
            // Implement BinaryFormatter object creation and  deserialization  in using block for FileStream object
            using (Stream readStream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                student = (Student)SoapFormatter.Deserialize(readStream);
            }
            // Write deserialization result to console
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Nationality);

        }
        // Define path for file
        // Implement SoapFormatter object creation and p serialization  in using block for FileStream object

        // Implement SoapFormatter object creation and  deserialization  in using block for FileStream object
        // Write deserialization result to console

        // Impement XmlFrm(Student p) method to serialize and deserialize p 
        static public void XmlFrm(Student p)
         {
            string FileName = @"D:\\testlabXML.xml";
        Student student = new Student();
        Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.Nationality);

            Console.WriteLine("********************************");
            // Implement BinaryFormatter object creation and p serialization  in using block for FileStream object
            XmlSerializer xmlwrite = new XmlSerializer(typeof(Student));
                
            using (Stream newStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlwrite.Serialize(newStream, p);
            }
            // Implement BinaryFormatter object creation and  deserialization  in using block for FileStream object
            using (Stream readStream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                student = (Student) xmlwrite.Deserialize(readStream);
            }
            // Write deserialization result to console
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Nationality);

        }
       
        // Define path for file
        // Create XmlSerializer serializer typeof Student       
        // Implement  p serialization  in using block for FileStream object

        // Create XmlSerializer deserializer typeof Student 
        // Implement   deserialization  in using block for FileStream object
        // Write deserialization result to console

    }
}

