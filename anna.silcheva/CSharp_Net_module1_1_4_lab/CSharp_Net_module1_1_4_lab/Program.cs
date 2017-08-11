using System;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType

        enum ComputerType { Desktop = 0, Laptop =1, Server = 2};
        // 2) declare struct Computer

       
        public struct Computer
        {
            public int  CPU;
            public double HGz;
            public int memory;
            public int HDD;

            //public Computer(int CPU_0, int HGz_0, int memory_0, int HDD_0)
            //{
            //    CPU = CPU_0;
            //    HGz = HGz_0;
            //    memory = memory_0;
            //    HDD = HDD_0;
            //}
        }


        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[,][] array_of_computers = new Computer[4, 3][];

            // 4) set the size of every array in jagged array (number of computers)
            array_of_computers[0, 0] = new Computer[2];
            array_of_computers[0, 1] = new Computer[2];
            array_of_computers[0, 2] = new Computer[1];
            array_of_computers[1, 1] = new Computer[3];
            array_of_computers[2, 0] = new Computer[3];
            array_of_computers[2, 1] = new Computer[2];
            array_of_computers[3, 0] = new Computer[1];
            array_of_computers[3, 1] = new Computer[1];
            array_of_computers[3, 2] = new Computer[3];



            // 5) initialize array
            // Note: use loops and if-else statements
            for (int i = 0; i < array_of_computers.GetLength(0) ; i++)
            {
                for (int j= 0; j < array_of_computers.GetLength(1) ; j++)
                {
                    if (array_of_computers[i, j] == null)
                    {
                        continue;
                    }
                    if (j == ComputerType.Desktop)
                    for (int k = 0; k < array_of_computers[i, j].Length; k++)
                    {
                        if (array_of_computers[i, j] == array_of_computers[i, 0])
                        {
                            array_of_computers.CPU = 4;
                            array_of_computers[i, 0][k].HDD = 500;
                            array_of_computers[i, 0][k].HGz = 2.5;
                            array_of_computers[i, 0][k].memory = 6;
                        }
                    
                        else if (array_of_computers[i, j] == array_of_computers[i, 1])
                        {
                            array_of_computers[i, 1][k].CPU = 2;
                            array_of_computers[i, 1][k].HDD = 250;
                            array_of_computers[i, 1][k].HGz = 1.7;
                            array_of_computers[i, 1][k].memory = 4;
                        }
                        else if (array_of_computers[i, j] == array_of_computers[i, 2])
                        {
                            array_of_computers[i, 2][k].CPU = 8;
                            array_of_computers[i, 2][k].HDD = 2048;
                            array_of_computers[i, 2][k].HGz = 3;
                            array_of_computers[i, 2][k].memory = 16;
                        }
                        }
                    }
                }


            }
            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            //int countDesktop = 0;
            //int countLaptop = 0;
            //int countServer = 0;
            //int countAllComp = 0;
            //for (int i = 0; i < array_of_computers.Length; i++)
            //{
            //    for (int j = 0; j < array_of_computers.Length; j++)
            //    {
            //        for (int k = 0; k < array_of_computers.Length; k++)
            //        {
                        
            //            if (array_of_computers[i, j] == array_of_computers[i, 0])
            //            {
            //                countDesktop = countDesktop + 1;
            //                Console.WriteLine(countDesktop);
            //            }
            //            else if (array_of_computers[i, j] == array_of_computers[i, 1])
            //                {
            //                    countLaptop = countLaptop + 1;
            //                    Console.WriteLine(countLaptop);
            //                }
            //            else if (array_of_computers[i, j] == array_of_computers[i, 2])
            //            {
            //                countServer = countServer + 1;
            //                Console.WriteLine(countServer);
            //            }
            //            countAllComp = countDesktop + countLaptop + countServer;
            //        }
            //    }
            //}
            
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
//}
