using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace stop_watch
{
    class StopWatch
    {
        private TimeSpan time1;
        private TimeSpan time2;

        public TimeSpan Start_Time()
        {
            Console.Write("Escribe la hora de inicio\t");
            var HourStart = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe los mimutos de inicio\t");
            var MinutStart = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe los segundos de inicio\t");
            var SecondStart = Convert.ToInt32(Console.ReadLine());

            return time1= new TimeSpan(HourStart,MinutStart,SecondStart);
        }

        public TimeSpan Stop_Time()
        {
            Console.Write("\nEscribe la hora de final\t");
            var HourFinal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe los mimutos de final\t");
            var MinutFinal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe los segundos de final\t");
            var SecondFinal = Convert.ToInt32(Console.ReadLine());

            return time2 = new TimeSpan(HourFinal,MinutFinal,SecondFinal);
        }
    }
}
