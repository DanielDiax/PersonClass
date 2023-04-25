using System;

namespace PersonClass
{
    class Persona
    {
        public int salario { get; set; }
        public string nombre { get; set; }

        public string PedirNombre()
        {
            Console.WriteLine("Porfavor ingrese su nombre.");
            nombre = Console.ReadLine();
            return (nombre);
        }

        public int PedirSalario()
        {
            Console.WriteLine("Ingrese el valor de su salario mensual.");
            salario = Convert.ToInt32(Console.ReadLine());
            return (salario);
        }

        public void CalcularImpuestos(int salario, string nombre)
        {
            int salarioAnual = salario * 12;

            if (salarioAnual >= 52000000)
            {
                Console.WriteLine($"{nombre} usted debe pagar impuestos ya que sus ingresos superan los 52.000.000 millones de pesos anuales");
            }
            else
            {
                Console.WriteLine($"{nombre} usted sigue siendo de la plebe relajado que no paga impuestos apenas gana {salarioAnual} al año");
            }
        }
    }
}
