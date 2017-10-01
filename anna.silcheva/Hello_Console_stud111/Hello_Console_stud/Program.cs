using System;
using System.Threading;

namespace Hello_Console_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                               // My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                               // Morse_code();
                                Console.WriteLine("");
                                break;                   
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error"+e.Message);
                    }                   
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary
        static void My_Binary()
        {
            //Implement positive integer variable input

            //Present it like binary string
            //   For example, 4 as 100

            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop

            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method

        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            //Declare int and string variables for decimal and binary presentations
            Console.WriteLine("Please enter your first number");
            //Implement two positive integer variables input
            uint num1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            uint num2 = uint.Parse(Console.ReadLine());
            //To present each of them in the form of unary string use for loop
            string s1 = "";
            for (int i = 1; i <= num1; i++)
            {
                s1 = s1.Insert(s1.Length, "1");

                
            }
            Console.WriteLine(" ");
            Console.Write(s1);
            // Console.WriteLine(s1);
            Console.WriteLine(" ");
            string s2 = "";
            for (int j = 1; j <= num2; j++)
            {
                s2 = s2.Insert(s2.Length, "1");
            }

            Console.WriteLine(" ");
            Console.Write(s2);
            Console.WriteLine(" ");
           

            ////Use concatenation of these two strings 
            ////Note it is necessary to use some symbol ( for example “#”) to separate
            
            if (num1 > num2)
            {
                uint diff = num1 - num2;
                for (int k =1 ; k <= diff; k++)
                {
                    Console.Write("1");
                
                }
            }
            else {
                    uint diff = num2 - num1;
                    for (int n = 1; n <= diff; n++)
                    {
                        Console.Write("1");
                       
                    }
                }
           

        string concat = s1 + @"#" + s2;
        Console.WriteLine(concat);


            //Check the numbers on the equality 0
            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 
            string subst = "1#1";
            string result = "";



            for (int i = 0; i < concat.Length; i++)
            {
                if (concat.Contains(subst))
                {
                    concat = concat.Replace("1#1", "#");
                    
                }
            }
            concat = concat.Replace("#", "");
            Console.WriteLine(concat);

        }

        //Delete the '#' from algorithm result

        //Output the result 
    }
        #endregion

        #region My_music
       /* static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }*/
        #endregion
    /*
       / #region Morse
        static void Morse_code()
        {   
            //Create string variable for 'sos'      

            //Use string array for Morse code
            string[,] Dictionary_arr = new string [,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};
            //Use ToCharArray() method for string to copy charecters to Unicode character array
            //Use foreach loop for character array in which

                //Implement Console.Beep(1000, 250) for '.'
                // and Console.Beep(1000, 750) for '-'

                //Use Thread.Sleep(50) to separate sounds
            //                  
        }

        #endregion
    }*/
}
