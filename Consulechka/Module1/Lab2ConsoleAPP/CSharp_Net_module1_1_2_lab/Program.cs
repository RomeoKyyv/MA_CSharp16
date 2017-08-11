using System;
namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            //bool boo = true;
            //char ch = '1';
            //byte b = 255;
            //sbyte sb = 125;
            //short sh = 10000;
            //ushort ush = 25;
            //int i = -223;
            //uint ui = 300;
            //long l = 100000;
            //ulong ul = 8;
            //decimal de = 10m;
            //float fl = 0.7f;
            //double d0 = 2.5;

            //2) declare constants of int and double. Try to change their values.

            //const int i = 10;
            //const double d0 = 2.5;
            //i = 15;
            //d0 = 2.6;

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            //var a = 20;
            //var b = 20.5;
            //a.GetType();
            //b.GetType();


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?

            //System.Int32 = i;
            //System.Double = d0;


            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?
                //int i = 223;
                //char ch = '1';
                //double d0 = 2.5;


                // 6) change values of variables from 1)


            }

            // 7)check values of variables from 1). Are they changed? Think, why

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char
            //char ch1 = (char)i;
            //bool -> short
            //short sh1 = (short)boo;
            //double -> long
            //long l1 = (long)d0;
            //float -> char
            //char ch2 = (char)fl;
            //int to char
            //char ch3 = (char)i;
            //decimal -> double
            //double d01 = (double)de;
            //byte -> uint
            //uint ui1 = (uint)b;
            //ulong -> sbyte
            //sbyte sb1 = (sbyte)ul;
            //9) and reverse conversion with fixing compilation errors.
            //char > int
            //int ii = (int)ch1;
            //short > bool
            //bool booo = (short)sh1;
            //long > double
            //double d00 = (double)l1;
            //char > float
            //char fll = (float)ch2;
            //char > int
            //int iii = (int)ch3;
            //double > decimal
            //decimal d000 = (decimal)d01;
            //uint > byte
            //byte bb = (byte)ui1;
            //sbyte > ulong
            //ulong ull = (ulong)sb1;
            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?

            //int? i = null;
            //Console.ReadKey();

        }
    }
}
