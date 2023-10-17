using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Clock
    {
        public int hour {  get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public string timeZone { get; set; }
        public bool is24HourFormat {  get; set; }

        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            if (is24HourFormat)
            {
                this.hour = hour;
            }
            else
            {
                this.hour = hour % 12;
            }
            this.minute = minute;
            this.second = second;
            this.timeZone = timeZone;
            this.is24HourFormat = is24HourFormat;
        }

        public void SetTime(int hour, int minute,int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public void DisplayTime()
        {
            Console.WriteLine($"Az aktuális idő: {this.hour}:{this.minute}:{this.second} Az időzóna: {this.timeZone}");
        }
        public void SetTimeZone(string timeZone)
        {
            this.timeZone = timeZone;
        }
        public void ToggleTimeFormat()
        {
            if (this.is24HourFormat)
            {
                this.is24HourFormat = false;
                this.hour = hour % 12;

            }
            else { this.is24HourFormat = true;}
        }
    }
}
