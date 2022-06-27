using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Time
    {
        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
        public Time()
        {
            Hour = Minute = 0;
        }
        public int Hour { get; set; }
        public int Minute { get; set; }

        public override string ToString()
        {
            return $"{Hour}:{Minute}";
        }
    }

    public class TimeDate
    {
        public TimeDate(int day, string month, int year, Time time)
        {
            Day = day;
            Month = month;
            Year = year;
            Time = time;
        }

        public int Year { get; set; }
        public string Month { get; set; }
        public int Day { get; set; }
        public Time Time { get; set; }

        public override string ToString()
        {
            return $"{Day}.{Month}.{Year} {Time}";
        }
    }
}
