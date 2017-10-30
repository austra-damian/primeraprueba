using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_consolagit
{
    class Program
    {
        static void Main(string[] args)
        {
            String accion = "nada";
            int aventura = 1;

            while (aventura > 0)
            {
                Console.WriteLine("Te encuentras en una sala completamente oscura, cuando tus ojos se adaptan a la ausencia de luz");
                accion = Console.ReadLine();
                switch (accion.ToLower())
                {
                    case "mirar":
                        Console.WriteLine("Miras a tu alrededor, ");
                        aventura = 0;
                        break;
                    case "matarse":
                        Console.WriteLine("Te matas");
                        aventura = 0;
                        break;
                    default:
                        Console.WriteLine("No puedes " + accion + " en este momoento");
                        aventura = 0;
                        break;
                }
            }

            Console.WriteLine("Gracias por jugar.");
            Console.ReadKey();
        }
    }
}
