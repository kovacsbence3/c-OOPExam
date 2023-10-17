using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            Clock myClock = new Clock(12, 30, 45, "UTC+2", true);
            // myClock.ToggleTimeFormat(); // Az ébresztő a 24 órás formát ismeri, így nem szólal meg 12óra után 12 órás formában
            List<Alarm> alarms = new List<Alarm>();
            alarms.Add(new Alarm(6, 0));
            alarms.Add(new Alarm(8, 0));
            // alarms.Add(new Alarm(12, 30)); // időpont az ébresztéshez
            // alarms[2].TurnOnAlarm(); // aktuális időponthoz az ébresztő bekapcsolása
            Timer myTimer = new Timer(10);

            // Kiírások

            myClock.DisplayTime();
            foreach (Alarm currentAlarm in alarms)
            {
                if (currentAlarm.IsAlarmTime(myClock.hour, myClock.minute) && currentAlarm.isAlarmOn)
                {
                    Console.WriteLine("Az ébresztő megszólalt");
                }
                else if((currentAlarm.IsAlarmTime(myClock.hour, myClock.minute) && !currentAlarm.isAlarmOn))
                {
                    Console.WriteLine("Az ébresztő mostanra van időzítve, de az ébresztés ki van kapcsolva");
                }
            }

            Console.WriteLine($"Valós idő kiírása a konzolra {myTimer.remainingSeconds} másodperc múlva (végtelen ciklussal)");
            myTimer.StartTimer();
            
            
            // Aktuális idő végtelen ciklussal

            bool run = true;        
            DateTime pastDateTimeUnformated = DateTime.Now;
            string pastDateTime = pastDateTimeUnformated.ToString("HH:mm:ss");
            while (run)
            {
                
                if (Console.KeyAvailable)
                {
                    break;
                }

                DateTime currentDateTimeUnformated = DateTime.Now;
                string currentDateTime = currentDateTimeUnformated.ToString("HH:mm:ss");
                int currentHour = int.Parse(currentDateTimeUnformated.ToString("HH"));
                int currentMinute = int.Parse(currentDateTimeUnformated.ToString("mm"));
                int currentSecond = int.Parse(currentDateTimeUnformated.ToString("ss"));

                if (currentDateTime != pastDateTime)
                {
                    Console.Clear();          
                    myClock = new Clock(currentHour, currentMinute, currentSecond, "UTC+2", true);
                    myClock.DisplayTime();
                    Console.WriteLine("Üss entert a megszakításhoz");
                    pastDateTime = currentDateTime;

                }

            }
            Console.ReadKey();
        }

    }
}
