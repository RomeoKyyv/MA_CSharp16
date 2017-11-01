using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace SharpProject.Lab62
{
    [Airplane(AirplaneType.Jet)]
    [Airplane(AirplaneType.SportPlane)]
    public class UniversalAirplane : Aircraft
    {
    }

    [Airplane]
    public class CargoPlane : Aircraft
    {
    }

    public class CheckSaveTrace
    {
        public void CheckClassAttribute(object input)
        {
            ProcessAttributes(input);
        }

        public void SaveTrace(object input)
        {
            WriteToFile("E:/temp/output.txt", ProcessAttributes(input).ToString());
        }

        public void EventLogging(object input)
        {
            var assemblyName = "Application";
            if (!EventLog.SourceExists(assemblyName))
            {
                EventLog.CreateEventSource(assemblyName, "Application log");
            }

            EventLog log = new EventLog();
            log.Source = assemblyName;
            log.WriteEntry(ProcessAttributes(input).ToString());
        }

        private void WriteToFile(string path, string content)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, content);
        }

        private StringBuilder ProcessAttributes(object input)
        {
            StringBuilder result = new StringBuilder();
            foreach (Attribute attribute in input.GetType().GetCustomAttributes())
            {
                string name = "Scanning " + input.GetType().Name;
                result.Append(name);
                result.Append("\n");
                Console.WriteLine(name);
                foreach (var fieldInfo in attribute.GetType().GetFields())
                {
                    string field = fieldInfo.Name + " is " + fieldInfo.GetValue(attribute);
                    result.Append(field);
                    result.Append("\n");
                    Console.WriteLine(field);
                }
            }
            return result;
        }
    }

    public abstract class Aircraft
    {
        public Aircraft()
        {
            Console.WriteLine("This is " + this.GetType().Name);
        }
    }

    public enum AirplaneType
    {
        SportPlane,
        CargoPlane,
        TurboProp,
        Jet
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class AirplaneAttribute : Attribute
    {
        public AirplaneType PlaneSubtype;

        public AirplaneAttribute(AirplaneType planeSubtype)
        {
            this.PlaneSubtype = planeSubtype;
        }

        public AirplaneAttribute()
        {
            this.PlaneSubtype = AirplaneType.TurboProp;
        }
    }
}