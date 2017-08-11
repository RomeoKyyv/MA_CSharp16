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

        enum ComputerType
        {
            desktops,
            laptops,
            servers
        };

        // 2) declare struct Computer
        
        struct Computer
        {
            public ComputerType compType;
            public int CPU;
            public string CPU_desc;
            public double freq;
            public string freq_desc;
            public int memory;
            public string memory_desc;
            public int HDD;
            public string HDD_desc;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)

            Computer[,][] departments = new Computer[4, 3][];

            // 4) set the size of every array in jagged array (number of computers)

            for (int i_dep = 0; i_dep < departments.GetLength(0); i_dep++)
            {
                for (int i_comp = 0; i_comp < departments.GetLength(1); i_comp++)
                {
                    if (i_dep == 0)
                    {
                        if (i_comp == 0) departments[i_dep, i_comp] = new Computer[2]; // desktop
                        else if (i_comp == 1) departments[i_dep, i_comp] = new Computer[2]; // laptop
                        else if (i_comp == 2) departments[i_dep, i_comp] = new Computer[1]; // server
                    }
                    else if (i_dep == 1)
                    {
                        if (i_comp == 1) departments[i_dep, i_comp] = new Computer[3]; // laptop
                    }
                    else if (i_dep == 2)
                    {
                        if (i_comp == 0) departments[i_dep, i_comp] = new Computer[3]; // desktop
                        else if (i_comp == 1) departments[i_dep, i_comp] = new Computer[2]; // laptop
                    }
                    else if (i_dep == 3)
                    {
                        if (i_comp == 0) departments[i_dep, i_comp] = new Computer[1]; // desktop
                        else if (i_comp == 1) departments[i_dep, i_comp] = new Computer[1]; // laptop
                        else if (i_comp == 2) departments[i_dep, i_comp] = new Computer[2]; // server
                    }
                }
            }

            // 5) initialize array
            // Note: use loops and if-else statements

            for (int i_dep = 0; i_dep < departments.GetLength(0); i_dep++)
            {
                Computer[] currentArrayComp;

                // desktops
                currentArrayComp = departments[i_dep, 0];
                if (currentArrayComp != null)
                {
                    for (int i = 0; i < currentArrayComp.Length; i++)
                    {
                        var currentComp = new Computer();
                        currentComp.compType = ComputerType.desktops;
                        currentComp.CPU = 4;
                        currentComp.CPU_desc = "cores";
                        currentComp.freq = 2.5;
                        currentComp.freq_desc = "HGz";
                        currentComp.HDD = 500;
                        currentComp.HDD_desc = "GB";
                        currentComp.memory = 6;
                        currentComp.memory_desc = "GB";
                        currentArrayComp[i] = currentComp;
                    };
                }
                // laptops
                currentArrayComp = departments[i_dep, 1];
                if (currentArrayComp != null)
                {
                    for (int i = 0; i < currentArrayComp.Length; i++)
                    {
                        var currentComp = new Computer();
                        currentComp.compType = ComputerType.laptops;
                        currentComp.CPU = 2;
                        currentComp.CPU_desc = "cores";
                        currentComp.freq = 1.7;
                        currentComp.freq_desc = "HGz";
                        currentComp.HDD = 250;
                        currentComp.HDD_desc = "GB";
                        currentComp.memory = 4;
                        currentComp.memory_desc = "GB";
                        currentArrayComp[i] = currentComp;
                    };
                }
                // servers
                currentArrayComp = departments[i_dep, 2];
                if (currentArrayComp != null)
                {
                    for (int i = 0; i < currentArrayComp.Length; i++)
                    {
                        var currentComp = new Computer();
                        currentComp.compType = ComputerType.servers;
                        currentComp.CPU = 8;
                        currentComp.CPU_desc = "cores";
                        currentComp.freq = 3;
                        currentComp.freq_desc = "HGz";
                        currentComp.HDD = 2;
                        currentComp.HDD_desc = "TB";
                        currentComp.memory = 16;
                        currentComp.memory_desc = "GB";
                        currentArrayComp[i] = currentComp;
                    };
                }
            }

            string userTextAction = "";

            do
            {
                Console.WriteLine("Select an action:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 - Count all types of computers.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("2 - Count all computers.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Find computer by max parameters:");
                Console.WriteLine("3,1 - CPU.");
                Console.WriteLine("3,2 - Frequency.");
                Console.WriteLine("3,3 - HDD.");
                Console.WriteLine("3,4 - Memory.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("4 - Find computer by lowes productivity (CPU and Memory).");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5 - Upgrades parameters:");
                Console.WriteLine("5,1 - Desktops.");
                Console.WriteLine("5,2 - Laptops.");
                Console.WriteLine("5,3 - Servers.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                Console.WriteLine("or 'exit' - exit programm");
                Console.WriteLine("or 'clear' - clear console.");

                userTextAction = Console.ReadLine();

                double userAction;
                if (double.TryParse(userTextAction, out userAction))
                {
                    // 6) count total number of every type of computers
                    // 7) count total number of all computers
                    // Note: use loops and if-else statements
                    // Note: use the same loop for 6) and 7)

                    //Console.WriteLine("1. Count all types of computers.");
                    //Console.WriteLine("2. Count all computers.");
                    if (userAction == 1 || userAction == 2)
                    {
                        #region action 1 or 2
                        int countsTypeDesktops = 0;
                        int countsTypeLaptops = 0;
                        int countsTypeServers = 0;

                        for (int i_dep = 0; i_dep < departments.GetLength(0); i_dep++)
                        {
                            Computer[] arrayTypeDesktops = departments[i_dep, 0];
                            Computer[] arrayTypeLaptops = departments[i_dep, 1];
                            Computer[] arrayTypeServers = departments[i_dep, 2];

                            if (arrayTypeDesktops != null) countsTypeDesktops += arrayTypeDesktops.Length;
                            if (arrayTypeLaptops != null) countsTypeLaptops += arrayTypeLaptops.Length;
                            if (arrayTypeServers != null) countsTypeServers += arrayTypeServers.Length;
                        }

                        if (userAction == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Number of different computers:");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Desktops - {0}", countsTypeDesktops);
                            Console.WriteLine("Laptops - {0}", countsTypeLaptops);
                            Console.WriteLine("Servers - {0}", countsTypeServers);
                        }
                        else if (userAction == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Number of computers: {0}", (countsTypeDesktops + countsTypeLaptops + countsTypeServers));
                        }
                        #endregion
                    }


                    // 8) find computer with the largest storage (HDD) - 
                    // compare HHD of every computer between each other; 
                    // find position of this computer in array (indexes)
                    // Note: use loops and if-else statements

                    //Console.WriteLine("3. Find computer by max parameters:");
                    //Console.WriteLine("3.1 CPU.");
                    //Console.WriteLine("3.2 Frequency.");
                    //Console.WriteLine("3.3 HDD.");
                    //Console.WriteLine("3.4 Memory.");
                    else if (userAction == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine("Error. You can input 3.1, 3.2, 3.3 or 3.4.");
                    }
                    else if (userAction > 3
                            && userAction < 4)
                    {
                        #region action 3
                        string infoTextConsole = "Max value {0} by type comp {1}: {2} {3}";
                        Computer emptyComp = new Computer();
                        Computer maxComp = new Computer();
                        if (userAction == 3.1)
                        {
                            #region 3.1
                            string infoText = "CPU";
                            foreach (var comp in departments)
                            {
                                if (comp != null)
                                {
                                    foreach (var compElements in comp)
                                    {
                                        if (maxComp.Equals(emptyComp))
                                            maxComp = compElements;

                                        else
                                        {
                                            int maxValue = maxComp.CPU;
                                            int currentValue = compElements.CPU;

                                            if (maxValue < currentValue)
                                                maxComp = compElements;
                                        }
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(infoTextConsole, infoText, maxComp.compType, maxComp.CPU, maxComp.CPU_desc);
                            #endregion
                        }
                        else if (userAction == 3.2)
                        {
                            #region 3.2
                            string infoText = "frequency";
                            foreach (var comp in departments)
                            {
                                if (comp != null)
                                {
                                    foreach (var compElements in comp)
                                    {
                                        if (maxComp.Equals(emptyComp))
                                            maxComp = compElements;

                                        else
                                        {
                                            double maxValue = maxComp.freq;
                                            double currentValue = compElements.freq;

                                            if (maxValue < currentValue)
                                                maxComp = compElements;
                                        }
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(infoTextConsole, infoText, maxComp.compType, maxComp.freq, maxComp.freq_desc);
                            #endregion
                        }
                        else if (userAction == 3.3)
                        {
                            #region 3.3
                            string infoText = "HDD";
                            foreach (var comp in departments)
                            {
                                if (comp != null)
                                {
                                    foreach (var compElements in comp)
                                    {
                                        if (maxComp.Equals(emptyComp))
                                            maxComp = compElements;

                                        else
                                        {
                                            int maxValue = maxComp.HDD;
                                            if (maxComp.HDD_desc == "TB")
                                                maxValue *= 1000;

                                            int currentValue = compElements.HDD;
                                            if (compElements.HDD_desc == "TB")
                                                currentValue *= 1000;

                                            if (maxValue < currentValue)
                                                maxComp = compElements;
                                        }
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(infoTextConsole, infoText, maxComp.compType, maxComp.HDD, maxComp.HDD_desc);
                            #endregion                        }
                        }
                        else if (userAction == 3.4)
                        {
                            #region 3.4
                            string infoText = "memory";
                            foreach (var comp in departments)
                            {
                                if (comp != null)
                                {
                                    foreach (var compElements in comp)
                                    {
                                        if (maxComp.Equals(emptyComp))
                                            maxComp = compElements;

                                        else
                                        {
                                            int maxValue = maxComp.memory;
                                            int currentValue = compElements.memory;

                                            if (maxValue < currentValue)
                                                maxComp = compElements;
                                        }
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(infoTextConsole, infoText, maxComp.compType, maxComp.memory, maxComp.memory_desc);
                            #endregion
                        }
                    }
                    #endregion
                
                    // 9) find computer with the lowest productivity (CPU and memory) - 
                    // compare CPU and memory of every computer between each other; 
                    // find position of this computer in array (indexes)
                    // Note: use loops and if-else statements
                    // Note: use logical oerators in statement conditions

                    //Console.WriteLine("4 - Find computer by lowes productivity (CPU and Memory).");
                    else if (userAction == 4)
                    {
                        #region action 3
                        string infoTextConsole = "Lowes productivity (CPU and Memory) by type comp {0}: CPU - {1} {2}, memory {3} {4}";
                        Computer emptyComp = new Computer();
                        Computer minComp = new Computer();
                        foreach (var comp in departments)
                        {
                            if (comp != null)
                            {
                                foreach (var compElements in comp)
                                {
                                    if (minComp.Equals(emptyComp))
                                        minComp = compElements;

                                    else
                                    {
                                        int minValueCPU = minComp.CPU;
                                        int currentValueCPU = compElements.CPU;
                                        int minValueMemory = minComp.memory;
                                        int currentValueMemory = compElements.memory;

                                        if (minValueCPU > currentValueCPU
                                            && minValueMemory > currentValueMemory)
                                            minComp = compElements;
                                    }
                                }
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(infoTextConsole, minComp.compType, minComp.CPU, minComp.CPU_desc, minComp.memory, minComp.memory_desc);
                        #endregion
                    }

                    // 10) make desktop upgrade: change memory up to 8
                    // change value of memory to 8 for every desktop. Don't do it for other computers
                    // Note: use loops and if-else statements

                    //Console.WriteLine("5 - Upgrades parameters:");
                    //Console.WriteLine("5,1 - Desktops.");
                    //Console.WriteLine("5,2 - Laptops.");
                    //Console.WriteLine("5,3 - Servers.");

                    if (userAction == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine("Error. You can input 5.1, 5.2 or 5.3.");
                    }
                    else if (userAction > 5 && userAction < 6)
                    {
                        #region action 5
                        ComputerType? typeUpgrade = null;
                        if (userAction == 5.1)
                            typeUpgrade = ComputerType.desktops;
                        else if (userAction == 5.2)
                            typeUpgrade = ComputerType.laptops;
                        else if (userAction == 5.3)
                            typeUpgrade = ComputerType.servers;
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Error. You can input 5.1, 5.2 or 5.3.");
                        }

                        if (typeUpgrade != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("What parameters need upgrades:");
                            Console.WriteLine("1 - CPU and Frequency.");
                            Console.WriteLine("2 - HDD.");
                            Console.WriteLine("3 - Memory.");

                            userTextAction = Console.ReadLine();

                            if (double.TryParse(userTextAction, out userAction))
                            {
                                string infoText = "Input value parameters ";
                                if (userAction != 1
                                    && userAction !=2
                                    && userAction != 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Error. You need enter type parameters 1, 2 or 3.");
                                }
                                else if (userAction == 1)
                                {
                                    #region upgrade_1
                                    // Ввод CPU
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(infoText + " CPU");
                                    userTextAction = Console.ReadLine();
                                    int valueCPU = 0;
                                    if (int.TryParse(userTextAction, out valueCPU)) ;

                                    // Ввод Frequency
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(infoText + " frequency");
                                    userTextAction = Console.ReadLine();
                                    int valueFreq = 0;
                                    if (int.TryParse(userTextAction, out valueFreq)) ;

                                    if (valueCPU == 0 || valueFreq == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error. You need enter CPU and Frequency parameters.");
                                    }
                                    else
                                    {
                                        for (int i_dep = 0; i_dep < 4; i_dep++)
                                        {
                                            for (int i_comp = 0; i_comp < 3; i_comp++)
                                            {
                                                Computer[] arrayComp = departments[i_dep, i_comp];
                                                if (arrayComp != null)
                                                {
                                                    for (int i = 0; i < arrayComp.Length; i++)
                                                    {
                                                        Computer currentComp = arrayComp[i];
                                                        if (currentComp.compType == typeUpgrade)
                                                        {
                                                            currentComp.CPU = valueCPU;
                                                            currentComp.freq = valueFreq;
                                                        }
                                                        arrayComp[i] = currentComp;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    #endregion
                                }
                                else if (userAction == 2)
                                {
                                    #region upgrade_2
                                    // Ввод HDD
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(infoText + " HDD");
                                    userTextAction = Console.ReadLine();
                                    if (int.TryParse(userTextAction, out int valueHDD))
                                    {
                                        for (int i_dep = 0; i_dep < 4; i_dep++)
                                        {
                                            for (int i_comp = 0; i_comp < 3; i_comp++)
                                            {
                                                Computer[] arrayComp = departments[i_dep, i_comp];
                                                if (arrayComp != null)
                                                {
                                                    for (int i = 0; i < arrayComp.Length; i++)
                                                    {
                                                        Computer currentComp = arrayComp[i];
                                                        if (currentComp.compType == typeUpgrade)
                                                        {
                                                            currentComp.HDD = valueHDD;
                                                        }
                                                        arrayComp[i] = currentComp;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error. You need enter HDD parameters.");
                                    }
                                    #endregion
                                }
                                else if (userAction == 3)
                                {
                                    #region upgrade_3
                                    // Ввод Memory
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(infoText + " memory");
                                    userTextAction = Console.ReadLine();
                                    if (int.TryParse(userTextAction, out int valueMemory))
                                    {
                                        for (int i_dep = 0; i_dep < 4; i_dep++)
                                        {
                                            for (int i_comp = 0; i_comp < 3; i_comp++)
                                            {
                                                Computer[] arrayComp = departments[i_dep, i_comp];
                                                if (arrayComp != null)
                                                {
                                                    for (int i = 0; i < arrayComp.Length; i++)
                                                    {
                                                        Computer currentComp = arrayComp[i];
                                                        if (currentComp.compType == typeUpgrade)
                                                        {
                                                            currentComp.memory = valueMemory;
                                                        }
                                                        arrayComp[i] = currentComp;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error. You need enter HDD parameters.");
                                    }
                                    #endregion
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("");
                                Console.WriteLine("Error. You can input 1, 2 or 3.");
                            }
                        }
                        #endregion
                    }

                        Console.ForegroundColor = ConsoleColor.Gray;
                    //userTextAction = Console.ReadLine();


                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();

                }
                else if (userTextAction == "clear")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                }
                else if (userTextAction == "exit")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Error. You need enter action or 'exit'.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Press any key...");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
            } while (userTextAction != "exit");

            Program g = new hz();
            Console.WriteLine("type g - " + g.GetType());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }

    class hz : Program
    {

    }

}
