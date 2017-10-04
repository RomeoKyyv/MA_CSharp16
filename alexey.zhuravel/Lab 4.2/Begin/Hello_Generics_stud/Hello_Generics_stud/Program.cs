using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Generics_stud
{

    public class Base<T> where T : new()
    {
        static Base()
        {
            new Base<T>();
            Console.WriteLine("The new instance of Base class created!");
        }

        
    }

    public sealed class Derived : Base<Derived>
    {
        static Derived()
        {
            new Derived();
            Console.WriteLine("The new instance of Derived class created!");
        }
    }

    public class Base_public_field<T> where T : new()
    {
        private T instance;

        public T Instance
        {
            get
            {
                Console.WriteLine("Public field");
                instance = new T();
                return instance;
            }
        }
    }

    public sealed class Derived_public_field : Base_public_field<Derived_public_field>
    {
        public Derived_public_field()
        {
            Console.WriteLine("Derived_public_field class created!");
        }
    }

    public class Base_static_Field<T> where T: new()
    {
        static int stat1;
        static int stat2;

        protected Base_static_Field()
        {
            Console.WriteLine("Base_static field created and " + stat1 + "and" + stat2);
        }
    }

    public class Derived_static_field : Base_static_Field<Derived_static_field>
    {

        public Derived_static_field()
        {
            Console.WriteLine("Derived_static field created");
        }
    }

    public class Base_publ<T> where T: new()
    {
        static Base_publ()
        {
            Console.WriteLine("New instance of Base_publ created");
            new Base_publ<T>();
        }
    }

    public class Derived_publ: Base_publ<Derived_publ>
    {
        public Derived_publ()
        {
            Console.WriteLine("New instance of Derived_publ created");
            new Derived_publ();
        }
    }



    public static class Curry_list
    {

        public static Func<TArg2, Func<TArg1, TResult>> Bnd<TArg1, TArg2, TResult>(this Func<TArg1, TArg2, TResult> f)
        {
            return (y) => ((x) => f(x, y));
        }
        
        static Curry_list()
        {

        }

    }

    class Program
    {
        Func<double, double, double> f = (x, y) => x - y;
        //var fBnd = f.Bnd()(2.0);


        static void Swap<T>() where T : new()
        {
            T puzzle = new T();
            Console.WriteLine("");
        }



        static void Main(string[] args)
        {

            Derived_public_field der = new Derived_public_field();
            //Base_public_field<Derived_public_field> der2 = Swap<Derived_public_field>();
            Derived_static_field der2 = new Derived_static_field();

            Swap<Derived_public_field>();

            Swap<Derived_static_field>();

            Swap<Derived_publ>();

            void NewMethod()
            {
                var source = new List<double> { 1.0, 2.4, 34.9, 9.02, 7.0 };
                var result = new List<double>();

            }


           

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

                                break;
                            case 2:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                
                                break;
                            case 3:
                                Console.WriteLine("Create Derived from static base constructor ...");
                               
                                break;
                            case 4:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                                                
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.WriteLine("Create currying ...");
                               
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

