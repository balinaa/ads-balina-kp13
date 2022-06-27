using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Value
    {
        public Value(string airoffarr, string gate, TimeDate departureTime) : this()
        {
            airoffarr = airoffarr;
            Gate = gate;
            DepartureTime = departureTime;
        }
        public Value(string flightCode):this()  
        {
            FlightCode = flightCode;
        }
        public Value()
        {
            IsDelayed = new Time();
            FlightCode = string.Empty;
        }
        public string airoffarr { get; set; }
        public string Gate { get; set; }
        public Time IsDelayed { get; set; }
        public TimeDate DepartureTime { get; set; }
        public string FlightCode { get; set; }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(FlightCode))
            {
                return $"[{airoffarr}] - {{{Gate}}} => {DepartureTime} + ({IsDelayed})";
            }
            else
            {
                return FlightCode;
            }
        }
    }
}
