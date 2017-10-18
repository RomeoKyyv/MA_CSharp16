using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace SharpProject.Lab52
{
    public class SerializationLab
    {
        public void RunLab()
        {
            Student chump = new Student();
            Student chumpette = new Student();

            chump.FirestName = "Phillip";
            chump.LastName = "J.Fry";
            chump.City = "New New York";
            chump.Occupation = "Courier";

            chumpette.FirestName = "Leelah";
            chumpette.LastName = "Turanga";
            chumpette.City = "New New York";
            chumpette.Occupation = "Pilot";

            XmlSerializer xml = new XmlSerializer(typeof(Student));
            SerializeXml(xml, "E:/temp/chumpSerializaed.xml", chump);
            SerializeXml(xml, "E:/temp/chumpetteSerializaed.xml", chumpette);

            IFormatter binaryFormatter = new BinaryFormatter();
            SerializeBinary(binaryFormatter, "E:/temp/chumpSerializaed.bin", chump);
            SerializeBinary(binaryFormatter, "E:/temp/chumpetteSerializaed.bin", chumpette);

            IFormatter soapFormatter = new SoapFormatter();
            SerializeBinary(soapFormatter, "E:/temp/chumpSerializaed.json", chump);
            SerializeBinary(soapFormatter, "E:/temp/chumpetteSerializaed.json", chumpette);
        }

        private void SerializeBinary(IFormatter formatter, string path, Student student)
        {
            using (FileStream fileStream = GenerateStream(path))
            {
                formatter.Serialize(fileStream, student);
            }
        }

        private void SerializeXml(XmlSerializer xml, string path, Student student)
        {
            using (FileStream fileStream = GenerateStream(path))
            {
                xml.Serialize(fileStream, student);
            }
        }

        private FileStream GenerateStream(string path)
        {
            return new FileStream(path, FileMode.Create, FileAccess.ReadWrite,
                FileShare.None);
        }
    }

    [Serializable]
    public class Student
    {
        public string FirestName, LastName, City;
        [field: NonSerialized()] public string Occupation;
    }
}