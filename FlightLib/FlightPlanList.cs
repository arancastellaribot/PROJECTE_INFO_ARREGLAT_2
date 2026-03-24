using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlanList
    {
        const int MAX_PLANES = 10; // número máximo de planes de vuelo
        int FlightCount; // número de planes de vuelo actualmente en la lista
        FlightPlan[] planes; // vector de plans de vol

        public FlightPlanList()
        {
            FlightCount = 0;
            planes = new FlightPlan[MAX_PLANES];
        }

        public string AddFlightPlan(FlightPlan plan) //Afegeix un pla de vol a la llista, si hi ha espai. 
                                                     //Retorna el nombre de plans de vol a la llista després d'afegir el nou pla de vol,
                                                     //t'avisa que està ple i noe s poden afegir més
        {
            if (FlightCount == MAX_PLANES)
            {
                string resposta_dolenta = "No hi ha més espai per plans de vol";
                return resposta_dolenta; // no hi ha espai per a més planes de vol
            }
            else
            {
                planes[FlightCount] = plan; // afegeix el pla de vol a la llista
                FlightCount++;
                string resposta_bona = "Pla de vol afegit correctament. Nombre de plans de vol a la llista: " + FlightCount;
                return resposta_bona; // retorna el nombre de planes de vol a la llista després d'afegir el nou pla de vol
            }
        }

        public FlightPlan GetFlightPlan (int i) //Retorna el plan de vol que es troba a la posició i de la llista, si existeix. Si no existeix, retorna null
        {
            if (i >= 0 && i < FlightCount)
            {
                return planes[i]; // retorna el plan de vol a la posició i de la llista
            }
            else
            {
                return null; // no existeix un plan de vol a la posició i de la llista
            }
        }
        public void Mover(double tiempo)
        {
            int i = 0;
            while (i < FlightCount && i > 0)
            {
                planes[i].Mover(tiempo); // mueve cada plan de vol de la lista durante el tiempo dado
                i++;
            }
        }
        public void EscribeConsola()
        {
            int i = 0;
            while (i < FlightCount)
            {
                planes[i].EscribeConsola(); // escribe en la consola la información de cada plan de vol de la lista
                i++;
            }
        }
    }
}
