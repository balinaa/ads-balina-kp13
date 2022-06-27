using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Key
    {
        public Key(string flightCode)
        {
            FlightCode = flightCode;
        }
        public Key()
        {
            FlightCode = string.Empty;
        }
        public string FlightCode { get; set; }

        public static bool operator== (Key key1, Key key2)
        {
            return key1.FlightCode == key2.FlightCode;
        }
        public static bool operator !=(Key key1, Key key2)
        {
            return key1.FlightCode != key2.FlightCode;
        }

        public override string ToString()
        {
            return FlightCode;
        }
    }
}
