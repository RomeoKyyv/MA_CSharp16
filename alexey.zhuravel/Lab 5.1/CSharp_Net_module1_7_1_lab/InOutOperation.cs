using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace CSharp_Net_module1_7_1_lab
{
    class InOutOperation
    {
        // 1) declare properties  CurrentPath - path to file (without name of file), CurrentDirectory - name of current directory,
        // CurrentFile - name of current file
        private string currentPath;

        public string CurrentPath
        {
            get { return currentPath; }
            set { currentPath = value; }
        }


        private int currentDirectory;

        public int CurrentDirectory
        {
            get { return currentDirectory; }
            set { currentDirectory = value; }
        }


        private int currentFile;

        public int CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }
        }



        // 2) declare public methods:
        //ChangeLocation() - change of CurrentPath; 
        // method takes new file path as parameter, creates new directories (if it is necessary)

        public void ChangeLocation(string filePath)
        {

        }


        // CreateDirectory() - create new directory in current location
        public void CreateDirectory(string path, string dirName)
        {
            DirectoryInfo dir = Directory.CreateDirectory(path+dirName);
            dir.Create();
        }


            public void CreateFile(string path, string fileName)
        {
            try
            {
                //using (FileStream fileStream = File.Open("Hello.txt", FileMode.Create))
                //{
                //    string msg = "Hello I/O";
                //    byte[] msg_Arr = Encoding.Default.GetBytes(msg);
                //    fileStream.Write(msg_Arr, 0, msg_Arr.Length);
                //}


                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                //using (StreamReader sr = File.OpenText(path))
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // WriteData() – save data to file
        // method takes data (info about computers) as parameter
        public void WriteData(Computer comp)
        {
            string str = "";
            str += "Cores:/t" + comp.Cores+"/n";
            str += "Frequency:/t" + comp.Frequency + "/n";
            str += "Memory:/t" + comp.Memory + "/n";
            str += "HDD:/t" + comp.Hdd + "/n/n";

            StreamWriter strWr = new StreamWriter(str);
            strWr.Close();

        }


        // ReadData() – read data from file
        // method returns info about computers after reading it from file
        public Computer ReadData()
        {
            Computer comp = new Computer();
            return comp;
        }

        // WriteZip() – save data to zip file
        // method takes data (info about computers) as parameter
        public void WriteZip()
        {
            
        }


        // ReadZip() – read data from file
        // method returns info about computers after reading it from file
        public void ReadZip()
        {

        }


        // ReadAsync() – read data from file asynchronously
        // method is async
        // method returns Task with info about computers
        // use ReadLineAsync() method to read data from file
        // Note: don't forget about await

        public async void ReadAsync()
        {

        }

        // 7)
        // ADVANCED:
        // WriteToMemoryStream() – save data to memory stream
        // method takes data (info about computers) as parameter
        // info about computers is saved to Memory Stream
        public void WriteToMemoryStream(Computer data)
        {

        }


        // use  method GetBytes() from class UnicodeEncoding to save array of bytes from string data 
        // create new file stream
        // use method WriteTo() to save memory stream to file stream 
        // method returns file stream

        // WriteToFileFromMemoryStream() – save data to file from memory stream and read it
        // method takes file stream as parameter
        // save data to file      


        // Note: 
        // - use '//' in path string or @ before it (for correct path handling without escape sequence)
        // - use 'using' keyword to organize correct working with files
        // - don't forget to check path before any file or directory operations
        // - don't forget to check existed directory and file before creating
        // use File class to check files, Directory class to check directories, Path to check path


    }
}
