using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.CoordinateSystems
{
    class DescartesSystem: Point
    {
        public DescartesSystem(double x, double y, double z = 0): base(x, y, z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //-------------------------------------------------------------
        public override double GetVectorRadius()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        //-------------------------------------------------------------
        public static new double GetDistanceBetweenPoints(Point A1, Point A2)
        {
            DescartesSystem P1 = (DescartesSystem)A1;
            DescartesSystem P2 = (DescartesSystem)A2;

            return Math.Sqrt(Math.Pow(P2.x-P1.x, 2) + Math.Pow(P2.y - P1.y, 2) + Math.Pow(P2.z - P1.z, 2));
        }

        //-------------------------------------------------------------
        public static new double GetAngleBetweenRadiusVectors(Point startVec1, Point endVec1, Point startVec2, Point endVec2)
        {
            DescartesSystem startVector1 = (DescartesSystem)startVec1;
            DescartesSystem endVector1 = (DescartesSystem)endVec1;
            DescartesSystem startVector2 = (DescartesSystem)startVec2;
            DescartesSystem endVector2 = (DescartesSystem)endVec2;

            double numerator = startVector1.x * startVector2.x + startVector1.y * startVector2.y + startVector1.z * startVector2.z;
            double denomerator = Math.Sqrt(Math.Pow(startVector1.x, 2) + Math.Pow(startVector1.y, 2) + Math.Pow(startVector1.z, 2)) * Math.Sqrt(Math.Pow(startVector2.x, 2) + Math.Pow(startVector2.y, 2) + Math.Pow(startVector2.z, 2));

            return numerator / denomerator;
        }

        //-------------------------------------------------------------
        public override Point AddRadiusVectors(Point radiusVector)
        {
            DescartesSystem vector = (DescartesSystem)radiusVector;
            DescartesSystem tempThis = (DescartesSystem)this;

            double x = tempThis.x + vector.x;
            double y = tempThis.y + vector.y;
            double z = tempThis.z + vector.z;

            return new DescartesSystem(x, y, z);
        }

        //-------------------------------------------------------------
        public override void Display()
        {
            Console.WriteLine("You coordinates of your object in Descarte's system are:");
            Console.WriteLine("X = {0}", this.x.ToString("F"));
            Console.WriteLine("Y = {0}", this.y.ToString("F"));
            Console.WriteLine("Z = {0}", this.z.ToString("F"));
        }

        //-------------------------------------------------------------
        public SphericalSystem ConvertDescarteToSpherical()
        {
            double ro = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y,2) + Math.Pow(this.z, 2) );
            double thetta = (ro == 0) ? 0 : Math.Acos(this.z / ro);
            double gamma = (this.z == 0) ? 0 : Math.Atan(this.y / this.z);

            return new SphericalSystem(ro, thetta, gamma);
        }

        //-------------------------------------------------------------
        public СylindricalSystem ConvertDescarteToCylindrical()
        {
            double cylindricalRo = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            double cylindricalThetta = (this.x==0)? 0: Math.Atan(this.y / this.x);
            double cylindricalZ = this.z;

            return new СylindricalSystem(cylindricalRo, cylindricalThetta, cylindricalZ);
        }

        //-------------------------------------------------------------
        double          x;
        double          y;
        double          z;
    }
}
