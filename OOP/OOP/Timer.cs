using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Timer
    {
        public int remainingSeconds {  get; set; }
        public Timer(int seconds) 
        {
            this.remainingSeconds = seconds;
        }
        public void SetTime (int seconds) 
        { 
            this.remainingSeconds = seconds; 
        }
        public void StartTimer()
        {
            Console.WriteLine("Az időzítő elindult");
            DateTime pastDateTimeUnformated = DateTime.Now;
            string pastDateTime = pastDateTimeUnformated.ToString("HH:mm:ss");
            int timeCounterReverse = this.remainingSeconds;
            int timeCounter = 0;
            Console.WriteLine($"Eltelt idő: {timeCounter}");
            Console.WriteLine($"Az időzítőből hátralévő idő: {timeCounterReverse}");
            while (timeCounterReverse != 0)
            {
                DateTime currentDateTimeUnformated = DateTime.Now;
                string currentDateTime = currentDateTimeUnformated.ToString("HH:mm:ss");
                
                if (currentDateTime != pastDateTime)
                {
                    // Console.Clear();
                    Console.WriteLine($"Eltelt idő: {timeCounter+1}");
                    Console.WriteLine($"Az időzítőből hátralévő idő: {timeCounterReverse-1}");
                    pastDateTime = currentDateTime;
                    timeCounterReverse--;
                    timeCounter++;
                }

            }

        }
    }
}
