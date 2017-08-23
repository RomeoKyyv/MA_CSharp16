using System;
using System.Threading;

namespace Hello_Class_stud
{

    class Morse_matrix: String_matrix, IMorse_crypt
    {

        public Morse_matrix()
        {
            this.offset_key = 0;
        }

        //-------------------------------------------------------------
        public Morse_matrix(string[,] alf, int shift)
        {
            this.offset_key = shift;
        }
        //-------------------------------------------------------------
        public Morse_matrix(int offset)
        {
            this.offset_key = offset;
        }

        //-------------------------------------------------------------
        public string crypt(string str)
        {
            return "";
        }

        //-------------------------------------------------------------
        public string decrypt(string[] str)
        {
            return "";
        }

        //-------------------------------------------------------------
        private void fd(string[,] Dict_arr)
        {
            for (int ii = 0; ii < Size1; ii++)
                for (int jj = 0; jj < Size_2; jj++)
                    this[ii, jj] = Dict_arr[ii, jj];
        }

        //-------------------------------------------------------------
        private void sd()
        {
            int off = Size_2 - offset_key;
            for (int jj = 0; jj < off; jj++)
                this[1, jj] = this[1, jj + offset_key];
            for (int jj = off; jj < Size_2; jj++)
                this[1, jj] = this[1, jj - off];
        }

        //-------------------------------------------------------------
        public static Morse_matrix operator +(Morse_matrix mm1, Morse_matrix mm2)
        {
            return new Morse_matrix(mm1.offset_key + mm2.offset_key);
        }



        //-------------------------------------------------------------
        public void Res_beep(string str)
        {
            char[] charArray = str.ToCharArray();

            foreach (char ch in charArray)
            {
                switch (ch)
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
        }

        //-------------------------------------------------------------
        public const int                Size_2 = Alphabet.Size;
        private int                     offset_key = 0;

    }
}

//Implement class Morse_matrix derived from String_matrix, which realize IMorse_crypt

//Realize crypt() with string parameter
//Use indexers

//Realize decrypt() with string array parameter
//Use indexers

//Implement Res_beep() method with string parameter to beep the string

//Implement Morse_matrix operator +

//Implement Morse_matrix constructor with the int parameter for offset
//Use fd(Alphabet.Dictionary_arr) and sd() methods

//Implement Morse_matrix constructor with the string [,] Dict_arr and int parameter for offset
//Use fd(Dict_arr) and sd() methods