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

        enum ComputerType { desktops, laptops, servers };
        
        // 2) declare struct Computer
 
        struct Computer
        {
            public ComputerType type;
            public int CPU;
            public string CPU_desc;
            public int freq;
            public string freq_desc;
            public int memory;
            public string memory_desc;
            public int HDD;
            public string HDD_desc;
        };
        

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)

            Computer[,] departments = new Computer[4, 3];

            // 4) set the size of every array in jagged array (number of computers)

            for (int i_dep = 0; i_dep < 4; i_dep++)
            {
                for (int i_comp = 0; i_comp < 3; i_comp++)
                {
                    departments[i_dep, i_comp] = new Computer();

                    //departments[i_dep, i_comp][1] = new Computer();
                    //departments[i_dep, i_comp][2] = new Computer();
                }
            }

            // 5) initialize array
            // Note: use loops and if-else statements


            for (int i_dep = 0; i_dep < 4; i_dep++)
            {
                for (int i_comp = 0; i_comp < 3; i_comp++)
                {
                    departments[i_dep, i_comp] = new Computer();

                    //departments[i_dep, i_comp][1] = new Computer();
                    //departments[i_dep, i_comp][2] = new Computer();
                }
            }


            int dd = 7;

            // 6) count total number of every type of computers
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
