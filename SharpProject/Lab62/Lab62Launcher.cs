using System;

namespace SharpProject.Lab62
{
    public class Lab62Launcher
    {
        public Lab62Launcher()
        {
            Console.WriteLine("Lunching plane...");
            TraceLog(new CargoPlane());
            Console.WriteLine("Lunching plane...");
            TraceLog(new UniversalAirplane());
            Console.WriteLine("Done....");
        }

        public void TraceLog(object input)
        {
            foreach (var attribute in input.GetType().GetCustomAttributes(false))
            {
                foreach (var fieldInfo in attribute.GetType().GetFields())
                {
                    Console.WriteLine(fieldInfo.Name + " is " + fieldInfo.GetValue(attribute));
                }
            }
        }
    }
}