namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
                Console.Write("Ingrese el tipo de fruta (Naranjas, Fresa o Mango): ");
                string tipoFruta = Console.ReadLine();

                Console.Write("Ingrese la distancia en kilómetros: ");
                int distanciaKm = int.Parse(Console.ReadLine());

                double precioPorCaja = 0;

                if (tipoFruta == "Naranjas")
                {
                    precioPorCaja = (distanciaKm < 30) ? 2 : 4;
                }
                else if (tipoFruta == "Fresa")
                {
                    precioPorCaja = (distanciaKm < 30) ? 6 : 9;
                }
                else if (tipoFruta == "Mango")
                {
                    precioPorCaja = (distanciaKm < 30) ? 3 : 5;
                }
                else
                {
                    Console.WriteLine("Tipo de fruta no válido.");
                    return;
                }

                double precioTotal = precioPorCaja;

                Console.WriteLine($"El precio total por la carga de {tipoFruta} a una distancia de {distanciaKm} km es: {precioTotal} soles.");
            
        }

    }
}
