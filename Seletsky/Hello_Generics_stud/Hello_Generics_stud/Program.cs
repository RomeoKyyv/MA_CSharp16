using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Generics_stud
{
    class Program
    {

        //**********************************************************
        // step2
        Func<double, double, double> f = (x, y) => x - y;
         public void MyMethod()
        {
        var source = new List<double> { 1.0, 2.4, 3.14, 5.16, 7.17 };
        var targ = new List<double>();
            var fBnd = f.Bnd()(2.0);

            Console.WriteLine("Source list {0}");
            foreach (var item in source)
            {
                Console.Write("{0}", item);
                targ.Add(fBnd(item));
            }
            Console.WriteLine();
            Console.WriteLine("Result list");
            foreach (var item in targ)
            {
                Console.Write("{ 0};",item);
            }
        }   

            static void Swap<T>() where T:new()
            {
                T puzzle = new T();
                Console.WriteLine( " puzzle = {0}",puzzle);
            }
        //static
            public class Base<T> where T : new()
        {
            //static constructor ?
            static Base()
            {
                Console.WriteLine("constructor of Base");
                T tt = new T();
                Console.WriteLine("Sozdali tt=",tt);
            }
        }

        public sealed class Derived : Base<Derived >
        {
            public Derived()
            {
                Console.WriteLine(" Constructor of Derived");
            }
        }
        //case 3
        // create the Base generic class ...
        public class Base_public_field<T> where T : new()
        {
            private T _instance;
            public T Instance
            {
                // set { Instance = value; }
                get
                {
                    Console.WriteLine("Obrasha k get of Base_public_field.Instance");
                    T _instance = new T();
                    return _instance;
                }
            }
            public Base_public_field()
            {
                T varT = new T();
                Console.WriteLine("Constructor Base_Public_field varT = {0}", varT);
            }
        }
            public  class Derived_pub_field:Base_public_field<Derived_pub_field>
            {
                public Derived_pub_field()
                {
                    Console.WriteLine("Construtor of Derive_pub_field ");
                    
                }
            }
        // case 4
        public class Base_static_field<T> where T : new()
        {
            // field
            static int Field;
            protected Base_static_field()
            {
                Console.WriteLine("Base_static_field constructor here");
            }
        }

        public sealed class Derived_st_fl: Base_static_field <Derived_st_fl>
        {
            public Derived_st_fl ()
            {
                Console.WriteLine("Constr der_st_fl here");
            }
        }

        //case 2

        public class Base_publ<T> where T : new()
        {
            static  Base_publ()
            {
                T t = new T();
                Console.WriteLine("Constr Base_publ ");           
            }
        }
        public sealed class Der_base_publ:Base_publ <Der_base_publ>
        {
            public Der_base_publ()
            {
                Console.WriteLine("constr der_base_publ here ");
            }
        }

        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.WriteLine(@"Please,  type the number:

                        Generics      Class Derived : Base<Derived>
                        1.  Static base constructor
                        2.  Protected base constructor (StackOverflow !)
                        3.  Static base constructor, public field
                        4.  Protected base constructor, static field

                        Generics      Delegats & List
                        5.  Generic delegates, extension methods, List  
                
                        ");
                    try
                    {                        
                        a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:                             
                                Console.WriteLine("Create Derived from static base constructor ...");
            //                Base<int> bb= new Base<int>();
                            Swap<Derived>();
                                
                         break;
                            case 2:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                Swap<Der_base_publ>();
                                break;
                            case 3:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                //            Base_public_field<int> bpf= new Base_public_field<int>();
                                Swap<Derived_pub_field>();
                               
                                break;
                            case 4:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                   Derived_st_fl dsf =  new Derived_st_fl ();                             
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.WriteLine("Create currying ...");
                                MyMethod();
                                Console.WriteLine("");
                                break;
                           
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    finally
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }


    }
}

