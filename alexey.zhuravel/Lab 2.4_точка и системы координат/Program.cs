using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Points.CoordinateSystems;

namespace Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] arrPoints = new Point [10]{ new DescartesSystem(128, -256, 512),
                                                new SphericalSystem(14,170,-60),
                                                new СylindricalSystem (98,120,6),
                                                new SphericalSystem(28,15,90),
                                                new СylindricalSystem (14,65,-32),
                                                new DescartesSystem(1, 10, 100),
                                                new DescartesSystem(2.5, 10, 15),
                                                new DescartesSystem(20, -20),
                                                new DescartesSystem(35, 4),
                                                new SphericalSystem(50,45,30)};

            //Convertions
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Convert descarte to cylindrical:");
            Console.ForegroundColor = ConsoleColor.White;

            DescartesSystem descarte1 = (DescartesSystem)arrPoints[6];
            СylindricalSystem cylindrical1 = (СylindricalSystem)descarte1.ConvertDescarteToCylindrical();
            descarte1.Display();
            cylindrical1.Display();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Convert descarte to shperical:");
            Console.ForegroundColor = ConsoleColor.White;

            SphericalSystem spherical = (SphericalSystem)descarte1.ConvertDescarteToSpherical();
            descarte1.Display();
            spherical.Display();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Convert cylindrical to descarte:");
            Console.ForegroundColor = ConsoleColor.White;

            СylindricalSystem cylindrical2 = (СylindricalSystem)arrPoints[2];
            DescartesSystem descarte2 = (DescartesSystem)cylindrical2.ConvertCylindricalToDescarte();
            cylindrical2.Display();
            descarte2.Display();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Convert spherical to descarte:");
            Console.ForegroundColor = ConsoleColor.White;

            SphericalSystem sherical3 = (SphericalSystem)arrPoints[1];
            DescartesSystem descarte3 = (DescartesSystem)sherical3.ConvertSphericalToDescarte();
            sherical3.Display();
            descarte3.Display();

            //GetVectorRadius
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Get vector radius:");
            Console.ForegroundColor = ConsoleColor.White;

            SphericalSystem sherical4 = (SphericalSystem)arrPoints[3];
            Console.WriteLine(sherical4.GetVectorRadius().ToString("F"));

            //GetDistanceBetweenPoints
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Get distance between points:");
            Console.ForegroundColor = ConsoleColor.White;

            DescartesSystem p1 = (DescartesSystem)arrPoints[0];
            DescartesSystem p2 = (DescartesSystem)arrPoints[7];
            double distance = DescartesSystem.GetDistanceBetweenPoints(p1, p2);
            Console.WriteLine(distance.ToString("F"));

            //GetAngleBetweenRadiusVectors
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Get angle between radius vectors:");
            Console.ForegroundColor = ConsoleColor.White;

            DescartesSystem start1 = (DescartesSystem)arrPoints[5];
            DescartesSystem end1 = (DescartesSystem)arrPoints[6];
            DescartesSystem start2 = (DescartesSystem)arrPoints[7];
            DescartesSystem end2 = (DescartesSystem)arrPoints[8];

            double angleBetweenRadiusVec = DescartesSystem.GetAngleBetweenRadiusVectors(start1, end1, start2, end2);
            Console.WriteLine(angleBetweenRadiusVec.ToString("F"));

            //AddRadiusVectors
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add radius vector:");
            Console.ForegroundColor = ConsoleColor.White;

            DescartesSystem r1 = (DescartesSystem)arrPoints[7];
            DescartesSystem r2 = (DescartesSystem)arrPoints[8];
            DescartesSystem r3 = (DescartesSystem)r1.AddRadiusVectors(r2);
            r3.Display();


            //Error
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Add radius vector:");
            //Console.ForegroundColor = ConsoleColor.White;

            //SphericalSystem s1 = (SphericalSystem)arrPoints[0];
            //SphericalSystem s2 = (SphericalSystem)arrPoints[3];
            //SphericalSystem s3 = (SphericalSystem)r1.AddRadiusVectors(r2);
            //s3.Display();

        }
    }
}
