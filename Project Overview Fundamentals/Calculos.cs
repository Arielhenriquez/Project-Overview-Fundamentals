using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Overview_Fundamentals
{
    public class Calculos : ICalculos
    {
        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public void Resta()
        {
            throw new NotImplementedException();
        }
        

        public void Multiplicacion()
        {
            throw new NotImplementedException();
        }
        public void Divide()
        {
            throw new NotImplementedException();
        }
    }
}
