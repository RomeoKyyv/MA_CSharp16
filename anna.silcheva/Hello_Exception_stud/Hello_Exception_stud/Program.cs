using System;

namespace Hello_Exception_stud
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("Observation titmouse flight");
            Bird My_Bird = new Bird("Titmouse", 20);

            //1. Create the skeleton code with the  basic exception handling for the menu in the main method 
            //try - catch
            // 1. begin
            char rdk;
            try
            {
                do
                {
                    rdk = Console.ReadKey().KeyChar;
                }
                while (rdk != ' ');
            }
            catch (Exception)
            {

                //2. Create code for the nested special exception handling in the main method
                //try - catch - catch - finally
                // 2. begin
                try {
                    Console.WriteLine("Monitoring in Try block");
                    Console.WriteLine(@"Please, type the number
                                1.array overflow
                                2.throw exception
                                3.user exception
                               ");
                    uint i = uint.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            int[] FlySpeed = { 25, 6, 7, 8, 10, 15, 18, 19 };
                            break;
                        case 2:
                            throw (new System.Exception("Oh,my system exeption"));
                        case 3:
                            My_Bird.FlyAway(5);
                            My_Bird.FlyAway(10);
                            break;
                        default:
                            break;
                    }
                }
                catch (BirdFlewAwayException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.When);
                    Console.WriteLine(e.Why);
                    Console.WriteLine(e.HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmouse");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("CLS exception: Message-" + e.Message + "Source-" + e.Source);
                }
                finally
                {
                    Console.WriteLine("For the next step...");
                }
                //3. Create the menu for three options in the inner try block  
                //In the second option throw the System.Exception
                // 3. begin
                
            }

                                //4. in case 1 code array overflow exception 
                                //in case 2 code throw (new System.Exception("Oh! My system exception..."));
                                //in case 3  code the sequentially incrementing of Bird speed until to the exception 

                            // 3. end

                    // 2. end

            // 1. end

        }

    }
}
