using System;
using System.Collections.Generic;
using System.Reflection;

namespace SharpProject.Lab62
{
    [Airplane(AirplaneType.Jet)]
    [Airplane(AirplaneType.SportPlane)]
    public class UniversalAirplane : Aircraft
    {
    }

    [Airplane]
    public class CargoPlane : Aircraft
    {
    }


    public abstract class Aircraft
    {
        public Aircraft()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

    public enum AirplaneType
    {
        SportPlane,
        CargoPlane,
        TurboProp,
        Jet
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class AirplaneAttribute : Attribute
    {
        public AirplaneType PlaneSubtype;

        public AirplaneAttribute(AirplaneType planeSubtype)
        {
            this.PlaneSubtype = planeSubtype;
        }

        public AirplaneAttribute()
        {
            this.PlaneSubtype = AirplaneType.TurboProp;
        }
    }
}