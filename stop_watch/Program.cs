using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop_watch
{
    class Program
    {
        static void Main(string[] args)
        {
            var instans = new StopWatch();
            bool value;


            do
            {
                value = false;
                var clock = instans.Start_Time();
                var last_clock = instans.Stop_Time();
                var resultado=clock-last_clock;

                Console.WriteLine("\nLa duracion entre el tiempo iniciar y el final es {0} dias {1} horas {2} minutos {3} segundos",
                    resultado.Days, resultado.Hours, resultado.Minutes, resultado.Seconds);
                
                Console.WriteLine("\nPresiona \"Y\" si qieres reiniciar el StopWatch o cualquier otra para salir");
                var answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    value= true;
                }
            }
            while (value);
        }
    }
}
