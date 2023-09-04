using System.Runtime.InteropServices;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Ingrese la edad del ganador: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de adivinanzas acertadas: ");
                int adivinanzasAcertadas = int.Parse(Console.ReadLine());

                int montoInicial = 0;

                if (edad >= 18)
                {
                    if (adivinanzasAcertadas < 3)
                    {
                        montoInicial = 30;
                    }
                    else
                    {
                        montoInicial = 50;
                    }
                }
                else
                {
                    if (adivinanzasAcertadas < 3)
                    {
                        montoInicial = 50;
                    }
                    else
                    {
                        montoInicial = 80;
                    }
                }

                int montoExtra = (edad * 5) + (adivinanzasAcertadas * 2);

                int montoFinal = montoInicial + montoExtra;

                Console.WriteLine($"El ganador recibe un premio de {montoFinal} soles.");

                Console.ReadKey();
            
        }

    }
}
