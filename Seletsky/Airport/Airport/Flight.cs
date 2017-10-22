using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
   public  class Flight
    {
        //rrival(departure) date and time, flight number, city/port of arrival(departure), airline, terminal, flight status
        //    (check-in, gate closed, arrived, departed at, unknown, canceled, expected at, delayed, in flight), gate
        public enum Ports { KIV, ZAP, LVI, VIN, DNP, HRS }
        public enum Airlines { MAU,LufGun,Vizz,KIY,Turk,BelA}
        public enum State { check_in, gate_closed, arrived, departed_at, unknown, canceled, expected_at, delayed, in_flight }

        DateTime ArrivalTime { set; get; }
        DateTime DepTime { set; get; }
        int FlihgtNum { set; get; }
        string CityArriv { set; get; }
        string CityDep { set; get; }
        string Airline { set; get; }
        string Status { set; get; }

        public void SetArrivalTime(DateTime time)
        {
            ArrivalTime = time;
        }
        public DateTime GetArrivalTime()
        {
            return this.ArrivalTime;
        }
        public void SetDepTime(DateTime time)
        {
            DepTime = time;
        }
        public DateTime GetDepTime()
        {
            return this.DepTime;
        }

        public void SetFlightNum(int flnum)
        {
            FlihgtNum = flnum;
        }
        public int GetFlightNum()
        {
            return this.FlihgtNum;
        }

        public void SetCityArriv(string str)
        {
            CityArriv=str;
        }
        public string GetCityArriv()
        {
            return this.CityArriv;
        }
        public void SetCityDep(string str)
        {
            CityDep = str;
        }
        public string GetCityDep()
        {
            return this.CityDep;
        }
        public void SetAirline(string str)
        {
            Airline = str;
        }
        public string GetAirline()
        {
            return this.Airline;
        }
        public void SetStatus(string str)
        {
            Status = str;
        }
        public string GetStatus()
        {
            return this.Status;
        }

    }
}
