using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace FinalProject
{
   public class Card
    {
        private bool active;
        private  double countMinutes;
        private DateTime startTime, endTime;
        public Card()
        {
            this.countMinutes = 0;
            this.active = false;
        }

        public double CountMinutes { get => countMinutes; set => countMinutes = value; }

        public void EnteringWork()
        {
            if (active)
            {
                Console.WriteLine("you're already at work");
                return;
            }

            active = true;
            startTime = DateTime.Now;
        }

        public void LeavingWork()
        {
            if (!active)
            {
                Console.WriteLine("you're already out of work");
                return;
            }
            active = false;
            endTime = DateTime.Now;
            countMinutes += (double)(endTime.Second - startTime.Second)/60;
            Console.WriteLine(countMinutes);
        }
    }

}
