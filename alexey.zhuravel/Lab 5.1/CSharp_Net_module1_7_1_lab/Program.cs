using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharp_Net_module1_7_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3) create collection of computers;

            List<Computer> comps = new List<Computer>() { new Computer { Cores = 2, Frequency = 1.6, Memory = 1000, Hdd = 500},
                                                          new Computer { Cores = 4, Frequency = 2.2, Memory = 1500, Hdd = 1000},
                                                          new Computer { Cores = 1, Frequency = 2.2, Memory = 800, Hdd = 300},
                                                          new Computer { Cores = 1, Frequency = 1.5, Memory = 400, Hdd = 320},
            };

            // set path to file and file name
            string path = @"E:\";


            // 4) save data and read it in the seamplest way (with WriteData() and ReadData() methods)
            InOutOperation io = new InOutOperation();
            //io.CreateDirectory(path, "Dir1");

            string text = io.WriteData(comps[1]);
            io.CreateFile(path, "File1.txt", text);


            // 5) save data and read it with WriteZip() and ReadZip() methods
            // Note: create another file for these operations
            string inFl = @"E:\1.txt";
            string outFl = @"E:\2.zip";
            io.WriteZip(inFl, outFl);

            // 6) read info about computers asynchronously (from the 1st file)
            // While asynchronous method will be running, Main() method must print ‘*’ 

            // use 
            // collection of Task with info about computers as type to get returned data from method ReadAsync()
            // use property Result of collection of Task to get access to info about computers

            // Note:
            // print all info about computers after reading from files


            // ADVANCED:
            // 8) save data to memory stream and from memory to file
            // declare file stream and set it to null
            // call method WriteToMemory() with info about computers as parameter
            // save returned stream to file stream

            // call method WriteToFileFromMemory() with parameter of file stream
            // open file with saved data and compare it with input info


            Console.ReadKey();
        }
    }
}
