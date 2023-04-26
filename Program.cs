using System;

namespace PersonClass
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("****Taller POO****\n\n\n");

            //Escribir las opciones a elegir
            Console.WriteLine("Digite 1 para calcular impuestos\n" +
                              "Digite 2 para usar calculadora\n" +
                              "Digite 3 para salir del programa.\n\n");


            //Recibir respuesta por consola
            int respuesta = Convert.ToInt32(Console.ReadLine());

            //Si la respuesta esta fuera de rango entrará en un bucle hasta que los valores sean superiores a 1 e inferiores a 3
            while (respuesta < 1 || respuesta > 3) 
            {
                Console.WriteLine("El valor de la respuesta esta fuera del rango valide las opciones, ingrese de nuevo la opción");
                respuesta = Convert.ToInt32(Console.ReadLine());
            }

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Bienvenido a el sistema de calculo de impuestos.\n\n");

                    Persona objPersona = new();

                    string nombre = objPersona.PedirNombre();

                    int salario = objPersona.PedirSalario();
                    objPersona.CalcularImpuestos(salario, nombre);
                    break;
                case 2:
                    Calculadora objCalculadora = new();
                    Console.WriteLine("Bienvenido a el sistema de calculo de impuestos.\n\n");
                    Console.WriteLine("ingrese el primer número.\n\n");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ingrese el segundo número.\n\n");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    objCalculadora.Operar(num1, num2);
                    break;
                case 3:
                    Console.Clear(); 
                    Console.WriteLine("Eso es todo.\n\n");
                    Console.ReadKey();
                    break;
                default:
                    Console.Write("\t Opción no válida...\n\n");
                    break;
            }

        }

       
    }
}
