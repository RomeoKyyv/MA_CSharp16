using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
<<<<<<< HEAD
        public   class Point
       {    // Filds
           public double Coord_X { set; get; }
           public double Coord_Y { set; get; }
           public double Coord_Z { set; get; }
           //Methods
           virtual public double Radius_vector() { return 0; }
           //abstract double Distance_point(Point p1);
          virtual public double Angle_rad_vect(Point p1) { return 0; }
  
    
      //     abstract public  double  (Point p1, Point p2);
       //    abstract double Add_rad_vect(Point p1, Point p2);
        // perehod   abstract Point(Point p, Ty t);


           public // override object.Equals
           override bool Equals(Object obj)
           {
               //       
               // See the full list of guidelines at
               //   http://go.microsoft.com/fwlink/?LinkID=85237  
               // and also the guidance for operator== at
               //   http://go.microsoft.com/fwlink/?LinkId=85238
               //

               if (obj == null || GetType() != obj.GetType())
               {
                   return false;
               }

               // TODO: write your implementation of Equals() here
               Point tnp = new Point();
               tnp = obj as Point;
               if (tnp.Coord_X == this.Coord_X)
               {
                   return true;
               }
               else return false;
               throw new NotImplementedException();
               return base.Equals(obj);
           }
       
       }
        public class  Decart_point:Point
        {
           // public double Coord_X { set; get; }
           //public double Coord_Y { set; get; }
           //public  double Coord_Z { set; get; }
=======
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
>>>>>>> c649799475a2bcfe2500b4894e35af3a02fce729
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
<<<<<<< HEAD
            
            public override   double Radius_vector (  ) 
           {
               Console.WriteLine("Here we calculate Radius_vector");
               Console.Write(" It equal {0}", Math.Sqrt(this.Coord_X * this.Coord_X + this.Coord_Y * this.Coord_Y));

               return Math.Sqrt(this.Coord_X * this.Coord_X + this.Coord_Y * this.Coord_Y);
           }
           public override  double Angle_rad_vect(Point p1)
           {

               Console.WriteLine("Here we calculate Angle_rad_vect ");
               Console.Write(" It equal {0}", this.Coord_X * p1.Coord_X + this.Coord_Y * p1.Coord_Y);

=======
            public override   double Radius_vector ( Point  p ) 
           {
               Console.WriteLine("Here we calculate Radius_vector");
               Console.Write(" It equal {0}", Math.Sqrt(p.Coord_X * p.Coord_X + p.Coord_Y * p.Coord_Y));

               return Math.Sqrt(p.Coord_X *p.Coord_X+p.Coord_Y*p.Coord_Y);
           }
           public override  double Angle_rad_vect(Point p1, Point p2)
           {

               Console.WriteLine("Here we calculate Angle_rad_vect ");
>>>>>>> c649799475a2bcfe2500b4894e35af3a02fce729
               return 0.1;
           }

        
        }

        static void Main(string[] args)
        {
            double D;
            string S;
<<<<<<< HEAD
            bool B;
            Decart_point P = new Decart_point(123,1234,5657);
            Decart_point P1 = new Decart_point(24.0, 225, -8000);
            D = P1.Radius_vector();
            D = P.Angle_rad_vect(P1);
            B = P.Equals(P1);
=======
            Decart_point P = new Decart_point();
            Decart_point P1 = new Decart_point(24.0, 225, -8000);
            D = P1.Radius_vector( P1);
            D = P.Angle_rad_vect(P, P1);
>>>>>>> c649799475a2bcfe2500b4894e35af3a02fce729
           S= Console.ReadLine();


        }
    }
}
