using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManger;
namespace Autos
{
    class Program
    {
        static void Main(string[] args)
        {
            vehiculo[] vehiculos = new vehiculo[] { new Tren(), new camión() , new automóvil() };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el tipo de vehículo (1: tren, 2: camión, 3: automóvil): ");
                string opcionStr = Console.ReadLine();
                int opcion;

                if (!int.TryParse(opcionStr, out opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Tipo de vehículo inválido. Intente nuevamente.");
                    continue;
                }

                vehiculo vehiculo = vehiculos[opcion - 1];
                vehiculo.AutoSoud();
            }
        }
}
}

