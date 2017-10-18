using System;
using System.IO;
using System.IO.Compression;
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
            CurrentDirectory = Directory.GetCurrentDirectory();
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

            if (!Directory.GetCurrentDirectory().Equals(CurrentDirectory))
            {
                ChangeLocation(CurrentDirectory);
            }
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            File.WriteAllText(CurrentDirectory + "/" + fileName, content);
        }

        public void ReadData(string path, string fileName)
        {
            CurrentFile = fileName;
            if (File.Exists(path + "/" + fileName))
            {
                if (!Directory.GetCurrentDirectory().Equals(CurrentDirectory))
                {
                    ChangeLocation(CurrentDirectory);
                }
                Console.WriteLine(File.ReadAllText(CurrentDirectory + "/" + fileName));
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }

        public void WriteZip(string path)
        {
            ZipHelper.Compress("E:/temp");
        }

        public void ReadZip(string path, string fileName)
        {
            ZipHelper.Decompress(new FileInfo("E:/temp" + "/" + fileName));
        }

        public byte[] WriteToMemory(string path)
        {
            return File.ReadAllBytes(path);
        }

        public void WriteToFileFromMemoryStream(string path, byte[] data)
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

    public class ZipHelper
    {
        public static void Compress(string directoryPath)
        {
            DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) &
                         FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                                CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);
                            }
                        }
                        FileInfo info = new FileInfo(directoryPath + "\\" + fileToCompress.Name + ".gz");
                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                            fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
                    }
                }
            }
        }

        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream =
                        new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
            }
        }
    }
}