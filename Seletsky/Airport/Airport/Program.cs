using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class Program
    {

        static void Main(string[] args)
        { int flnum;
            Flight[] flights = new Flight[100];

            void MyConsoleClear()
            {
                Console.SetCursorPosition(0, 10);
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("                                                                               ");
                }
            }
            void InputFlight(Flight flight)
            {
                string str;
                //Console.Clear();
                MyConsoleClear();
                Console.SetCursorPosition(10, 10);
                Console.WriteLine("         If entering  Spacebar field do not change !");
                Console.WriteLine("Input Flight Number");
                Int32.TryParse(Console.ReadLine(), out flnum);
                flight.SetFlightNum(flnum);

                Console.WriteLine("Input city arrive");
                str = (Console.ReadLine());
                if (str!=" ")
                flight.SetCityArriv(str);

                Console.WriteLine("Input city departe");
                str = (Console.ReadLine());
                flight.SetCityDep(str);


            }
            void GenerateFl(int ii )
            {
                int tmp = 0;
                string prt;
                Random rndobj = new Random();
                for (int i = 0; i < ii; i++)
                {
                    flights[i] = new Flight();
                    var year = rndobj.Next(2016, 2020);
                    var month = rndobj.Next(1, 13);
                    var days = rndobj.Next(1, DateTime.DaysInMonth(year, month) + 1);

                     var rndtime =  new DateTime(year, month, days,
                        rndobj.Next(0, 24), rndobj.Next(0, 60), rndobj.Next(0, 60), rndobj.Next(0, 1000));

                    flights[i].SetDepTime(rndtime);
                    rndtime=rndtime.AddHours(rndobj.Next(0, 12));
                    rndobj.Next(0, 60);
                    rndtime.AddMinutes(rndobj.Next(0, 60));
                    flights[i].SetArrivalTime(rndtime);
                    

                    tmp = rndobj.Next(5);

                    // generate fl Arr port
                    tmp = rndobj.Next(5);
                    prt = Enum.GetName(typeof(Flight.Ports), tmp);
                    flights[i].SetCityArriv(prt);

                    tmp = rndobj.Next(1000);
                    flights[i].SetFlightNum(tmp);

                    tmp = rndobj.Next(5);
                    prt = Enum.GetName(typeof(Flight.Ports), tmp);
                    flights[i].SetCityDep(prt);

                    tmp = rndobj.Next(6);
                    prt = Enum.GetName(typeof(Flight.Airlines), tmp);
                    flights[i].SetAirline(prt);
                }
            }
            void PrintFlight(int num)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("| Ind | Fl num | Time  Depart |City Dep| Time   Arriv |Cyti Arriv | Airline|");
               // Console.WriteLine("****************************************************************************");
                for (int i = 0; i < num; i++)
                {
                  if (flights[i]!=null)   Console.WriteLine("|{0,4} |{1,7} |{2:yy MM dd HH:mm}|{3,7} |{4:yy MM dd HH:mm}|{5,9}  |{6,7} |", i,flights[i].GetFlightNum(), flights[i].GetDepTime(), flights[i].GetCityDep(),flights[i].GetArrivalTime(), flights[i].GetCityArriv(), flights[i].GetAirline());

                }
                Console.WriteLine("*****************************************************************************");

                Console.BackgroundColor = ConsoleColor.Black;

            }


            //1 –input, deleting and editing of  this information
            // 2–search by the flight number, time of arrival, arrival(departure) port and the information output about the found flight in the specified format
            // 3–search of the flight which is the nearest (1 hour) to the specified time to / from the specified port and output  information sorted by time
            // 4–output of the emergency information(evacuation, fire, etc.)
            // 5–menu for input and output
            int a=0;
            int b = 0;
            GenerateFl(5);

            try
            {
                do
                {
                     Console.BufferWidth=240;
                    Console.Clear();
                    Console.WindowWidth = 100;
                    Console.SetWindowPosition(0, 0);

                    Console.SetWindowSize(100, 40);

                    PrintFlight(5);



                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  input, deleting and editing flight information
                    2.  search by the flight number, time of arrival, arrival(departure) port
                    3.  search of the flight which is the nearest (1 hour) to the specified time to / from the specified port
                    4.  morse sos output of the emergency information(evacuation, fire, etc.)
                    5.  menu for input and output
          
                    ");
                    
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:

                                Console.Clear();
                                PrintFlight(5);
                                Console.SetCursorPosition(20, 10);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(@"Input press 1
                    Delete press 2
                    Edit press 3
                                                    ");
                                b = (int)uint.Parse(Console.ReadLine());
                                int c = 0;
                                switch (b)
                                {
                                    case 1:
                                        Console.WriteLine("Enter Flight index for new flight");
                                        c = (int)uint.Parse(Console.ReadLine());
                                        if ((flights[c]!=null) &&  ( flights[c].GetFlightNum() != 0 ))
                                        {
                                            Console.WriteLine("Flight exist!");
                                            break;
                                        }
                                        else
                                        {
                                            flights[c] = new Flight();
                                            InputFlight(flights[c]);
                                            Console.WriteLine("");
                                            break;
                                        }
                                    case 2:
                                        Console.WriteLine("Enter Flight index for delete");
                                        c = (int)uint.Parse(Console.ReadLine());
                                        flights[c] = null;
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter Flight index for edit");
                                        c = (int)uint.Parse(Console.ReadLine());
                                        Console.WriteLine("  Fl Num is : {0}",flights[c].GetFlightNum());
                                        Console.ReadKey();
                                        // flights[c] = new Flight();
                                        InputFlight(flights[c]);
                                        break;

                                    default:
                                        break;
                                }
                                // My_strings();
                                
                                break;
                            case 2:
                                //My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                //My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                //Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
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
    }
}
