using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace SharpProject.Lab51
{
    public class InOutOperation
    {
        private string CurrentPath, CurrentDirectory, CurrentFile;

        public void ChangeLocation(string path)
        {
            CreateDirectory(path);
            CurrentPath = path;
            Directory.SetCurrentDirectory(path);
        }

        public void CreateDirectory(string path)
        {
            if (path != null && !Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void WriteData(string fileName, string content)
        {
            CurrentFile = fileName;
            if (File.Exists(fileName))
            {
                if (!Directory.GetCurrentDirectory().Equals(CurrentDirectory))
                {
                    ChangeLocation(CurrentDirectory);
                }
                File.WriteAllText(CurrentDirectory + fileName, content);
            }
        }

        public void ReadData(string fileName)
        {
            CurrentFile = fileName;
            if (File.Exists(fileName))
            {
                if (!Directory.GetCurrentDirectory().Equals(CurrentDirectory))
                {
                    ChangeLocation(CurrentDirectory);
                }
                Console.WriteLine(File.ReadAllText(CurrentDirectory + fileName));
            }
        }

        public void WriteZip()
        {
            
        }

        public void WriteToMemory()
        {
        }

        public void WriteToFileFromMemoryStream()
        {
        }

        public void ReadAsync()
        {
            AsyncStuff stuff = new AsyncStuff();
            Thread thread = new Thread(this.WaitFor);
            thread.Start();
            while (!AsyncStuff.isThreadFinished)
            {
                Console.Write("*");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Done!");
        }

        private void WaitFor()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write("|");
            }
            AsyncStuff.isThreadFinished = true;
        }
    }

    public class AsyncStuff
    {
        public static bool isThreadFinished = false;
    }
}