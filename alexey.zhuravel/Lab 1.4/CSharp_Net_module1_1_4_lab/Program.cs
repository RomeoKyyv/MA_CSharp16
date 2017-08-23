using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    enum ComputerType { DESKTOP, LAPTOP, SERVER };

    class Program
    {
        // 1) declare enum ComputerType
        

        // 2) declare struct Computer
        struct Computer
        {
            public ComputerType compType;
            public int RAM;
            public byte cores;
            public float frequency;
            public int HDD;
        }


        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            
            Computer[,][] comp = new Computer[4, 3][];

            // 4) set the size of every array in jagged array (number of computers)
            //(Department, ComputerType)
            comp[0, 0] = new Computer[2];
            comp[0, 1] = new Computer[2];
            comp[0, 2] = new Computer[1];

            comp[1, 1] = new Computer[3];

            comp[2, 0] = new Computer[3];
            comp[2, 1] = new Computer[2];

            comp[3, 0] = new Computer[1];
            comp[3, 1] = new Computer[1];
            comp[3, 2] = new Computer[2];

            // 5) initialize array
            // Note: use loops and if-else statements
            //comp[1, 0][1].compType = ComputerType.DESKTOP;
            //comp[1, 0][1].RAM = 6;
            //comp[1, 0][1].cores = 4;
            //comp[1, 0][1].frequency = 2.5f;
            //comp[1, 0][1].HDD = 500;

            //comp[1, 0][2].compType = ComputerType.DESKTOP;
            //comp[1, 0][2].RAM = 6;
            //comp[1, 0][2].cores = 4;
            //comp[1, 0][2].frequency = 2.5f;
            //comp[1, 0][2].HDD = 500;

            //comp[3, 0][1].compType = ComputerType.DESKTOP;
            //comp[3, 0][1].RAM = 6;
            //comp[3, 0][1].cores = 4;
            //comp[3, 0][1].frequency = 2.5f;
            //comp[3, 0][1].HDD = 500;
            
            //comp[3, 0][2].compType = ComputerType.DESKTOP;
            //comp[3, 0][2].RAM = 6;
            //comp[3, 0][2].cores = 4;
            //comp[3, 0][2].frequency = 2.5f;
            //comp[3, 0][2].HDD = 500;

            //comp[3, 0][3].compType = ComputerType.DESKTOP;
            //comp[3, 0][3].RAM = 6;
            //comp[3, 0][3].cores = 4;
            //comp[3, 0][3].frequency = 2.5f;
            //comp[3, 0][3].HDD = 500;

            //comp[4, 0][1].compType = ComputerType.DESKTOP;
            //comp[4, 0][1].RAM = 6;
            //comp[4, 0][1].cores = 4;
            //comp[4, 0][1].frequency = 2.5f;
            //comp[4, 0][1].HDD = 500;


            for (int i = 0; i < 4; i++)
            {
                int len = comp[i, 0].Length;

                for (int j = 0; j < len; j++)
                {
                    comp[i, 0][j].compType = ComputerType.DESKTOP;
                    comp[i, 0][j].RAM = 6;
                    comp[i, 0][j].cores = 4;
                    comp[i, 0][j].frequency = 2.5f;
                    comp[i, 0][j].HDD = 500;

                }
            }

            for (int i = 0; i < 4; i++)
            {
                int len = comp[i, 1].Length;

                for (int j = 1; j <= len; j++)
                {
                    comp[i, 1][j].compType = ComputerType.LAPTOP;
                    comp[i, 1][j].RAM = 4;
                    comp[i, 1][j].cores = 2;
                    comp[i, 1][j].frequency = 1.7f;
                    comp[i, 1][j].HDD = 250;

                }
            }

            for (int i = 0; i < 4; i++)
            {
                int len = comp[i, 2].Length;

                for (int j = 1; j <= len; j++)
                {
                    comp[i, 2][j].compType = ComputerType.SERVER;
                    comp[i, 2][j].RAM = 16;
                    comp[i, 2][j].cores = 8;
                    comp[i, 2][j].frequency = 3.0f;
                    comp[i, 2][j].HDD = 2000;

                }
            }

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            int total = 0;
            int totalDesktop = 0;
            int totalLaptop = 0;
            int totalServer = 0;

            total = comp.Length;
            Console.WriteLine("Total number of computers is {0} units", total);


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

        }
 
    }
}
