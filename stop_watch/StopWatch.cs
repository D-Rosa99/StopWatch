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
        private Stopwatch time1 = new Stopwatch();
        private TimeSpan time2;

        public void Start_Time()
        {
            Console.Write("Presiona 'Enter' para iniciar el StopWatch ");
            Console.ReadLine();
            time1.Start();
            Console.WriteLine("Tiempo Inicial: "+DateTime.Now.ToLongTimeString());
            Stop_Time();
        }

        public void Stop_Time()
        {
            Console.Write("\nPresiona 'Enter' cuando quieras detener el StopWatch y mostrar la duracion \ndel tiempo inicial hasta este momento ");
            Console.ReadLine();
            time1.Stop();
            time2 = time1.Elapsed;
            Console.WriteLine("\nTiempo Final: " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("La duracion es: "+time2+" Desde el tiempo inicial");
            Console.WriteLine("\nPreciona 'Enter' para continuar la cuenta o 'R' para reiniciar el StopWatch");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "r")
            {
                Console.Clear();
                Start_Time();
            }
            else
            {
                time1.Start();
                Stop_Time();
            }
        }
    }
}
