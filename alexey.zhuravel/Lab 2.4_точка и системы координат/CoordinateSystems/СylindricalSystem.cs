using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.CoordinateSystems
{
    class СylindricalSystem: Point
    {
        public СylindricalSystem(double cylindricalRo, double cylindricalThetta, double cylindricalZ) : base(cylindricalRo, cylindricalThetta, cylindricalZ)
        {
            this.cylindricalRo = cylindricalRo;
            this.cylindricalGamma = cylindricalThetta;
            this.cylindricalZ = cylindricalZ;
        }

        //-------------------------------------------------------------
        public override double GetVectorRadius()
        {
            DescartesSystem descarte = this.ConvertCylindricalToDescarte();

            return descarte.GetVectorRadius();
        }

        //-------------------------------------------------------------
        public static new double GetDistanceBetweenPoints(Point A1, Point A2)
        {
            DescartesSystem P1 = ((СylindricalSystem)A1).ConvertCylindricalToDescarte();
            DescartesSystem P2 = ((СylindricalSystem)A2).ConvertCylindricalToDescarte();

            return DescartesSystem.GetDistanceBetweenPoints(P1, P2);
        }

        //-------------------------------------------------------------
        public static new double GetAngleBetweenRadiusVectors(Point startVec1, Point endVec1, Point startVec2, Point endVec2)
        {
            DescartesSystem startVector1 = ((СylindricalSystem)startVec1).ConvertCylindricalToDescarte();
            DescartesSystem startVector2 = ((СylindricalSystem)startVec2).ConvertCylindricalToDescarte();
            DescartesSystem endVector1 = ((СylindricalSystem)endVec1).ConvertCylindricalToDescarte();
            DescartesSystem endVector2 = ((СylindricalSystem)endVec2).ConvertCylindricalToDescarte();


            return DescartesSystem.GetAngleBetweenRadiusVectors(startVector1, startVector2, endVector1, endVector2);
        }

        //-------------------------------------------------------------
        public override Point AddRadiusVectors(Point radiusVector)
        {

            DescartesSystem thisObject = this.ConvertCylindricalToDescarte();
            DescartesSystem descarte = (DescartesSystem)(thisObject.AddRadiusVectors(radiusVector));

            СylindricalSystem cylindrical = descarte.ConvertDescarteToCylindrical();
      

            return new СylindricalSystem(cylindrical.cylindricalRo, cylindrical.cylindricalGamma, cylindrical.cylindricalZ);
        }

        //-------------------------------------------------------------
        public override void Display()
        {
            Console.WriteLine("You coordinates of your object in Сylindrical system are:");
            Console.WriteLine("ro = {0}", this.cylindricalRo.ToString("F"));
            Console.WriteLine("thetta = {0}", this.cylindricalGamma.ToString("F"));
            Console.WriteLine("z = {0}", this.cylindricalZ.ToString("F"));
        }

        //-------------------------------------------------------------
        public DescartesSystem ConvertCylindricalToDescarte()
        {
            double x = this.cylindricalRo * Math.Cos(this.cylindricalGamma);
            double y = this.cylindricalRo * Math.Sin(this.cylindricalGamma);
            double z = this.cylindricalZ;

            return new DescartesSystem(x,y,z);
        }

        //-------------------------------------------------------------
        public SphericalSystem ConvertCylindricalToSpherical()
        {
            double ro = Math.Sqrt(Math.Pow(this.cylindricalRo, 2) + Math.Pow(this.cylindricalZ, 2));
            double thetta = Math.Atan(this.cylindricalRo / this.cylindricalZ);
            double gamma = this.cylindricalGamma;

            return new SphericalSystem(ro, thetta, gamma);
        }

        //-------------------------------------------------------------
        double          cylindricalRo;
        double          cylindricalGamma;
        double          cylindricalZ;
    }
}
