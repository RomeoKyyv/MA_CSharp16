using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
       abstract public  class Point
       {    // Filds
           public double Coord_X;
           public double  Coord_Y;
           public double  Coord_Z;
           //Methods
           abstract public  double Radius_vector (Point p);
         //  abstract double Distance_point(Point p1,Point p2);
           abstract public double Angle_rad_vect(Point p1,Point p2);
      //     abstract public  double  (Point p1, Point p2);
       //    abstract double Add_rad_vect(Point p1, Point p2);
        // perehod   abstract Point(Point p, Ty t);
      }
        public class  Decart_point:Point
        {   
           public double  Coord_X {set;get;}
           public double Coord_Y { set; get; }
           public  double Coord_Z { set; get; }
            public Decart_point()
            {
                Console.WriteLine("Here we construct Decart_point");
                this.Coord_X = 0;
                this.Coord_Y = 0;
                this.Coord_Z = 0;
  
            }

            public Decart_point(double x, double y, double z)
            {
                Console.WriteLine("Here we construct Decart_point random");

                this.Coord_X = x;
                this.Coord_Y = y;
                this.Coord_Z = z;
            }
            public override   double Radius_vector ( Point  p ) 
           {
               Console.WriteLine("Here we calculate Radius_vector");
               Console.Write(" It equal {0}", Math.Sqrt(p.Coord_X * p.Coord_X + p.Coord_Y * p.Coord_Y));

               return Math.Sqrt(p.Coord_X *p.Coord_X+p.Coord_Y*p.Coord_Y);
           }
           public override  double Angle_rad_vect(Point p1, Point p2)
           {

               Console.WriteLine("Here we calculate Angle_rad_vect ");
               return 0.1;
           }

        
        }

        static void Main(string[] args)
        {
            double D;
            string S;
            Decart_point P = new Decart_point();
            Decart_point P1 = new Decart_point(24.0, 225, -8000);
            D = P1.Radius_vector( P1);
            D = P.Angle_rad_vect(P, P1);
           S= Console.ReadLine();


        }
    }
}
