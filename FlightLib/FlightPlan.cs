using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position initialPosition; //Posicion inicial
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;


        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.initialPosition = new Position(cpx, cpy);
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }

        // Metodos
        public string GetId()
        {
            return id; 
        }   
        public void SetId(string id)
        {
            this.id = id; 
        }
        public Position GetInitialPosition()
        {
            return initialPosition;
        }

        public void SetInitialPosition(Position i)
        {
            this.initialPosition = i;
        }

        public Position GetCurrentPosition()
        {
            return currentPosition;
        }

        public void SetCurrentPosition(Position p)
        {
            this.currentPosition = p;
        }

        public Position GetFinalPostion()
        {
            return finalPosition;
        }

        public void SetFinalPostion(Position f)
        {
            this.finalPosition = f;
        }
        public double GetVelocidad()
        {
            return velocidad;
        }
        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad; }

        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {

            // 1. Si ya ha llegado, no calculamos nada y salimos.
            if (this.AvionDestino())
            {
                return;
            }
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);

            if (currentPosition.Distancia(nextPosition) < hipotenusa)
                currentPosition = nextPosition;
            else
                currentPosition = finalPosition;
        }
        public void Restart() // Reinicia el plan de vuelo, es decir, vuelve a la posición inicial
        {
            this.currentPosition = new Position(initialPosition.GetX(), initialPosition.GetY());
        }
        public bool AvionDestino()
        { 
            bool resultado = false;
            if (currentPosition.Distancia(finalPosition) <= 0.001)
                resultado = true;
            return resultado;
        }
        public double Distancia(FlightPlan b)// Retorna la distancia entre el vuelo actual y el vuelo b
        {
            return currentPosition.Distancia(b.currentPosition);
        }
        public bool Conflicte(FlightPlan b, double distanciaSeguretat)
        { 
            bool resultado = false;
            if (currentPosition.Distancia(b.currentPosition) < distanciaSeguretat)
                resultado = true;
            Console.WriteLine("Hi ha conflicte entre el vol {0} i el vol {1}");
            return resultado;
        }
        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad);
            Console.WriteLine("Posición actual: ({0:F2},{1:F2})", currentPosition.GetX(), currentPosition.GetY());
            if (this.AvionDestino())
                Console.WriteLine("El avión ha llegado a su destino");
            Console.WriteLine("******************************");
        }
    }
}
