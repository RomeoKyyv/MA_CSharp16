using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hello_Console_stud
{
    class Morse
    {
        public void Init()
        {            
            Console.WriteLine("Please enter your word: ");
            sos = Console.ReadLine();

            charArray = sos.ToCharArray();

            foreach (char ch in charArray)
            {
                int pos = FindPosInDictionary(ch, Dictionary_arr);
                string posBeep = Dictionary_arr[1, pos];

                char[] posBeepChar = posBeep.ToArray();
                this.PlayMusic(posBeepChar);
            }
        }

        //-------------------------------------------------------------
        int FindPosInDictionary(char ch, string[,] Dictionary_arr)
        {
            string str = ch.ToString();
            int len = Dictionary_arr.Length;
           
            for (int i = 0; i < len; i++)
            {
                if (Dictionary_arr[0, i] == str)
                {
                    return i;
                }
            }
            return 0;
        }

        //-------------------------------------------------------------
        void PlayMusic(char[] posBeepChar)
        {
            for (int j = 0; j < posBeepChar.Length; j++)
            {
                Console.WriteLine("Char = {0}", posBeepChar[j]);
                this.Sounds(posBeepChar[j]);                
            }
        }

        //-------------------------------------------------------------
        void Sounds (char posBeepChar)
        {
            switch (posBeepChar)
            {
                case '.':
                    Console.Beep(1000, 250);
                    break;
                case '-':
                    Console.Beep(1000, 750);
                    break;
                case ' ':
                    Thread.Sleep(50);
                    break;
                default:
                    throw new Exception("Wrong symbol met which can't be applied for Morse alphabet");



            }                
        }

        //-------------------------------------------------------------
        string sos;
        char[] charArray;
        string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                                                    "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3",
                                                     "4", "5", "6", "7", "8", "9"},
                                                   { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ",
                                                        ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ",
                                                        "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----",
                                                            ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."}
                                                    };

    }
}

//Use string array for Morse code            

//Use ToCharArray() method for string to copy charecters to Unicode character array
//Use foreach loop for character array in which

//Implement Console.Beep(1000, 250) for '.'
// and Console.Beep(1000, 750) for '-'

//Use Thread.Sleep(50) to separate sounds
//Create string variable for 'sos'