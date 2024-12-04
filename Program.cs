using System;
using System.Collections.Generic;
using System.Linq;

namespace Banquer;

class Program
{
    static void Main(string[] args)
    {
        Banquer banquer = new Banquer();
        bool aplicacio = true;
        Console.WriteLine("");
        menu();
        Console.WriteLine("----------------------------------------");
        while(aplicacio){
            
            Console.WriteLine("Selecciona una opció del menú:");
            char opcio = Console.ReadLine()?.FirstOrDefault() ?? '\0';
            switch (opcio)
            {
                case 'a':
                    banquer.CrearClient();
                    break;

                case 'b':
                    banquer.ConsultarClient();
                    break;

                case 'c':
                    banquer.OperarClient();
                    break;

                case 'd':
                    aplicacio = false;
                    Console.WriteLine("Cerrando aplicación...");
                    break;
                case 'm':
                    menu();
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción del menú.");
                    break;
            }
            Console.WriteLine("----------------------------------------");
        }

    }
    static void menu(){
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("a. Crear client");
        Console.WriteLine("b. Consultar client");
        Console.WriteLine("c. Operar client");
        Console.WriteLine("d. Tancar aplicacio");
        Console.WriteLine("m. Mostrar menu");
    }
}
