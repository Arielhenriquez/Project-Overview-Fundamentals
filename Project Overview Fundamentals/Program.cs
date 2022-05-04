using System;
using static Project_Overview_Fundamentals.Persona;

namespace Project_Overview_Fundamentals
{
    
    public enum diasSemana
    {
        Lunes, Martes, Miercoles, Jueves, Viernes
    }
    
    class Generic<TNombre, TEdad>
    {
        public TNombre Nombre { get; set; }
        public TEdad Edad { get; set; }

        public override string ToString()
        {
            return Nombre + " tiene" + " " + Edad;
        }
    }

    class Animal
    {
        public string nombre = Console.ReadLine();
        public void Correr() 
        {
            Console.WriteLine($"El: {nombre} corre");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Classes and objects
            Console.WriteLine("Ingrese el tipo de animal:");
            var cat = new Animal();
            cat.Correr();
            //Type paramaters
            var datosPersona = new Generic<string, int>()
            {
                Nombre = "Waldis",
                Edad = 22
            };
            Console.WriteLine(datosPersona);
            //Base classes
            Peter peter = new Peter();
            peter.Nombre = " Peter parker";
            peter.Edad = 20;
            peter.MostrarDatos();

            //Interfaces
            Calculos calculos = new Calculos();
            Console.WriteLine("La sumatoria es: " + calculos.Suma(5, 5));

            //Enums
            diasSemana dias = diasSemana.Lunes;
            Console.WriteLine(dias);

            //Nullable types
            int? numero = null;
            if (numero.HasValue)
            {
                Console.WriteLine(numero);
            }
            else
            {
                Console.Write("No tiene ningun valor.");
            }
        }
    }
}
