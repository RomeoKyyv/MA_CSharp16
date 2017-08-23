using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.CoordinateSystems
{
    class SphericalSystem: Point
    {
        public SphericalSystem(double ro, double thetta, double gamma): base(ro, thetta, gamma)
        {
            this.ro = ro;
            this.thetta = thetta;
            this.gamma = gamma;
        }

        //-------------------------------------------------------------
        public override double GetVectorRadius()
        {
            DescartesSystem descarte = this.ConvertSphericalToDescarte();
            
            return descarte.GetVectorRadius();
        }

        //-------------------------------------------------------------
        public static new double GetDistanceBetweenPoints(Point A1, Point A2)
        {
            DescartesSystem P1 = ((SphericalSystem) A1 ).ConvertSphericalToDescarte();
            DescartesSystem P2 = ((SphericalSystem) A2 ).ConvertSphericalToDescarte();

            return DescartesSystem.GetDistanceBetweenPoints(P1, P2);
        }

        //-------------------------------------------------------------
        public static new double GetAngleBetweenRadiusVectors(Point startVec1, Point endVec1, Point startVec2, Point endVec2)
        {
            DescartesSystem startVector1 = ((SphericalSystem)startVec1).ConvertSphericalToDescarte();
            DescartesSystem startVector2 = ((SphericalSystem)startVec2).ConvertSphericalToDescarte();
            DescartesSystem endVector1 = ((SphericalSystem)endVec1).ConvertSphericalToDescarte();
            DescartesSystem endVector2 = ((SphericalSystem)endVec2).ConvertSphericalToDescarte();

            return DescartesSystem.GetAngleBetweenRadiusVectors(startVector1, startVector2, endVector1, endVector2);
        }

        //-------------------------------------------------------------
        public override Point AddRadiusVectors(Point radiusVector)
        {
            DescartesSystem thisObject = this.ConvertSphericalToDescarte();
            DescartesSystem descarte = (DescartesSystem)(thisObject.AddRadiusVectors(radiusVector));

            SphericalSystem spherical = descarte.ConvertDescarteToSpherical();

            return new SphericalSystem(spherical.ro, spherical.thetta, spherical.gamma);
        }

        //-------------------------------------------------------------
        public override void Display()
        {
            Console.WriteLine("You coordinates of your object in Spherical system are:");
            Console.WriteLine("ro = {0}", this.ro.ToString("F"));
            Console.WriteLine("thetta = {0}", this.thetta.ToString("F"));
            Console.WriteLine("gamma = {0}", this.gamma.ToString("F"));
        }

        //-------------------------------------------------------------
        public DescartesSystem ConvertSphericalToDescarte()
        {
            double x = this.ro * Math.Sin(this.thetta) * Math.Cos(this.gamma);
            double y = this.ro * Math.Sin(this.thetta) * Math.Sin(this.gamma);
            double z = this.ro * Math.Cos(this.thetta);

            return new DescartesSystem(x, y, z);
        }

        //-------------------------------------------------------------
        public СylindricalSystem ConvertSphericalToCylindrical()
        {
            double cylindricalRo = this.ro * Math.Sin(this.thetta)*Math.Cos(this.gamma);
            double cylindricalThetta = this.ro * Math.Sin(this.thetta) * Math.Sin(this.gamma); ;
            double cylindricalZ = this.ro * Math.Cos(this.thetta);

            return new СylindricalSystem(cylindricalRo, cylindricalThetta, cylindricalZ);
        }
        //-------------------------------------------------------------
        double          ro;
        double          thetta;
        double          gamma;
    }
}
