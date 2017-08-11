using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType { desktop, laptop, server };

        // 2) declare struct Computer
        int i = 0;
        struct Computer
        {
            public string CPU;
            public int memory;
            public int HDD;
            public ComputerType type;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[,][] Comps = new Computer[4, 3][];

            // 4) set the size of every array in jagged array (number of computers)
            Comps[0, 0] = new Computer[2];
            Comps[0, 1] = new Computer[2];
            Comps[0, 2] = new Computer[1];
            Comps[1, 1] = new Computer[3];
            Comps[2, 0] = new Computer[3];
            Comps[2, 1] = new Computer[2];
            Comps[3, 0] = new Computer[1];
            Comps[3, 1] = new Computer[1];
            Comps[3, 2] = new Computer[2];

            // 5) initialize array
            // Note: use loops and if-else statements
            for (int row = 0; row < Comps.GetLength(0); row++)
            {
                for (int col = 0; col < Comps.GetLength(1); col++)
                {
                    if (Comps[row,col] == null)
                    {
                        continue;
                    }
                    if (col == 0)
                    {
                        for (int i = 0; i < Comps[row, col].Length; i++)
                        {
                            Computer Desktop;
                            Desktop.type = ComputerType.desktop;
                            Desktop.CPU = "4 cores, 2,5 HGz";
                            Desktop.memory = 6;
                            Desktop.HDD = 500;
                            Comps[row, col][i] = Desktop;
                        }
                    }
                    else if (col == 1)
                    {
                        for (int i = 0; i < Comps[row, col].Length; i++)
                        {
                            Computer Laptop;
                            Laptop.type = ComputerType.laptop;
                            Laptop.CPU = "2 cores, 1,7 HGz";
                            Laptop.memory = 4;
                            Laptop.HDD = 250;
                            Comps[row, col][i] = Laptop;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Comps[row, col].Length; i++)
                        {
                            Computer Server;
                            Server.type = ComputerType.server;
                            Server.CPU = "8 cores, 3 HGz";
                            Server.memory = 16;
                            Server.HDD = 2000;
                            Comps[row, col][i] = Server;
                        }
                    }
                }
            }

            // 6) count total number of every type of computers
            int TypeD = 0;
            int TypeL = 0;
            int TypeS = 0;
            for (int row = 0; row < Comps.GetLength(0); row++)
            {
                for (int col = 0; col < Comps.GetLength(1); col++)
                {
                    if (Comps[row, col] == null) 
                    {
                        continue;
                    }
                    for (int i = 0; i < Comps[row, col].Length; i++)
                    {
                        if (Comps[row, col][i].type == ComputerType.desktop)
                        {
                            TypeD++;
                        }
                        else if (Comps[row, col][i].type == ComputerType.laptop)
                        {
                            TypeL++;
                        }
                        else
                        {
                            TypeS++;
                        }
                    }
                }
            }
            Console.WriteLine("number of desktop " + TypeD);
            Console.WriteLine("number of laptop " + TypeL);
            Console.WriteLine("number of server " + TypeS);
            Console.WriteLine("number of computers " + (TypeD+TypeL+TypeS));
            Console.ReadLine();


            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)



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
