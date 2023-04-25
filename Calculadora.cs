using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Calculadora
    {
        public int select = 0;
        public double Operar(int num1, int num2)
        {
            double result = 0;

            Console.WriteLine("Digite 1 para calcular suma\n" +
                              "Digite 2 para calcular resta\n" +
                              "Digite 3 para calcular multiplicacion.\n"+
                              "Digite 4 para calcular división.\n");
            select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("No se contemplan más opciones");
                    break;
            }
            return result;
        }
    }
}
