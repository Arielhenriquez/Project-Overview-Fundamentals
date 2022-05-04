using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Overview_Fundamentals
{
    
    public class Persona
    {
        public int Edad{ get; set; }
        public string Nombre { get; set; }    

        public void MostrarDatos()
        {
            Console.WriteLine($"Los datos de la persona son:{Nombre} y {Edad}");
        }

        public class Peter: Persona
        {
            public double Peso { get; set; }
        }
    }
}
