using System;

namespace SharpProject.Lab62
{
    public class Lab62Launcher
    {
        public Lab62Launcher()
        {
            Console.WriteLine("Lunching plane...");
            CheckSaveTrace trace = new CheckSaveTrace();
            trace.CheckClassAttribute(new CargoPlane());
            trace.SaveTrace(new CargoPlane());
            trace.EventLogging(new CargoPlane());
            Console.WriteLine("Done....");
        }
    }
}