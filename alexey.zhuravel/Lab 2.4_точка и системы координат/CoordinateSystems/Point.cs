using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.CoordinateSystems
{
    abstract class Point
    {
        public Point(double coordinateParam1, double coordinateParam2, double coordinateParam3)
        {
            this.coordinateParam1 = coordinateParam1;
            this.coordinateParam2 = coordinateParam2;
            this.coordinateParam3 = coordinateParam3;
        }
        //-------------------------------------------------------------
        public abstract double GetVectorRadius();

        //-------------------------------------------------------------
        public static double GetDistanceBetweenPoints(Point A1, Point A2)
        { throw new Exception("You wrongly used the basic class"); }

        //-------------------------------------------------------------
        public static double GetAngleBetweenRadiusVectors(Point startVector1, Point endVector1, Point startVector2, Point endVector2)
        { throw new Exception("You wrongly used the basic class"); }

        //-------------------------------------------------------------
        public abstract Point AddRadiusVectors(Point radiusVector);

        //-------------------------------------------------------------
        public abstract void Display();

        //-------------------------------------------------------------
        double                 coordinateParam1;
        double                 coordinateParam2;
        double                 coordinateParam3;
    }
}
