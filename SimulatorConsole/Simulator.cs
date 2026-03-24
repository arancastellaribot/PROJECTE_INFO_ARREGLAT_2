using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightLib;


namespace SimulatorConsole
{
    public class Simulator
    {

        static void Main(string[] args)
        {
            FlightPlanList list = new FlightPlanList();// Creamos una lista de planes de vuelo
            try { 
            Console.WriteLine("Escribe el identificador");
            //   string nombre = Console.ReadLine();
            string identificador = Console.ReadLine();

            Console.WriteLine("Escribe la velocidad");
            double velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
            string linea = Console.ReadLine();
            string[] trozos = linea.Split(' ');
            double ix = Convert.ToDouble(trozos[0]);
            double iy = Convert.ToDouble(trozos[1]);

            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            double fx = Convert.ToDouble(trozos[0]);
            double fy = Convert.ToDouble(trozos[1]);

            FlightPlan plan_a = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);

            list.AddFlightPlan(plan_a); // Afegim plan a la llista

                Console.WriteLine("Escribe el identificador");
            //   string nombre = Console.ReadLine();
            identificador = Console.ReadLine(); ;

            Console.WriteLine("Escribe la velocidad");
            velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            ix = Convert.ToDouble(trozos[0]);
            iy = Convert.ToDouble(trozos[1]);

            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            fx = Convert.ToDouble(trozos[0]);
            fy = Convert.ToDouble(trozos[1]);

            FlightPlan plan_b = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);

            list.AddFlightPlan(plan_b);


            double distanciaSeguridad = 10;
            int cicles = 100;
            int tempsCicles = 10;

            int i = 0;
            while (i < cicles)
                {
                    list.Mover(tempsCicles);
                    list.EscribeConsola();
                    if (list.GetFlightPlan(0).Conflicte(list.GetFlightPlan(1), distanciaSeguridad))
                    {
                        Console.WriteLine("¡Alerta de conflicto!");
                        i++;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: formato de número no válido.");
                Console.ReadLine();
            }
        }
    }
}
