using System;
using System.Collections.Generic;
using System.Linq;

namespace Banquer;

class Program
{
    static void Main(string[] args)
    {
        
        List<Client> clients = new List<Client>();
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
                    CrearClient(ref clients);
                    break;

                case 'b':
                    ConsultarClient(ref clients);
                    break;

                case 'c':
                    OperarClient(ref clients);
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
    static void CrearClient(ref List<Client> clients)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Escriu el teu nom: ");
        var nom = Console.ReadLine();
        while(nom == ""){
            Console.WriteLine("El nom no pot estar en blanc. Introdueix un nom:");
            nom=Console.ReadLine();
        }
        bool clientTrobat = false;
        foreach(Client client in clients){
            if(client.Nom == nom){
                clientTrobat = true;
                break;
            }
        }

        if(!clientTrobat){
            Client client = new Client(nom);
            clients.Add(client);
            Console.WriteLine("El client s'ha afegit correctament.");
        }
        else{
            Console.WriteLine("Ja existeix un client amb aquest nom.");
        }
    }
    static void ConsultarClient(ref List<Client> clients)
    {
        Console.WriteLine("----------------------------------------");
        if(clients.Count == 0){
            Console.WriteLine("No hi ha clients a consultar.");
        }
        else{
            Console.WriteLine("Nom del client a consultar: ");
            string nom = Console.ReadLine();
            bool clientTrobat = false;

            foreach(Client client in clients){
                if(client.Nom == nom){
                    clientTrobat = true;
                    Console.WriteLine($"{client.Nom} tens aquest saldo a la teva compte: {client.Compte}");
                    break;
                }
            }

            if (!clientTrobat)
            {
                Console.WriteLine("El client no existeix.");
            }
        }
    }
    static void OperarClient(ref List<Client> clients){

        Console.WriteLine("----------------------------------------");
        if(clients.Count == 0){
            Console.WriteLine("No hi ha clients per fer operacions.");
        }
        else{
            Console.WriteLine("Nom del client a operar: ");
            string nom = Console.ReadLine();
            bool clientTrobat = false;

            foreach(Client client in clients){
                if(client.Nom == nom){
                    clientTrobat = true;
                    Console.WriteLine($"Ets en {client.Nom}: ");
                    Console.WriteLine($"a. Afegir diners.");
                    Console.WriteLine($"b. Treure diners.");
                    char opcio = Console.ReadLine()?.FirstOrDefault() ?? '\0';
                    switch (opcio)
                    {
                        case 'a':
                            client.posarDiners();
                            break;
                        case 'b':
                            client.treureDiners();
                            break;
                        default:
                            Console.WriteLine("Opció no válida. Si us plau, selecciona una opció válida.");
                            break;
                    }
                }
            }
            if (!clientTrobat)
            {
                Console.WriteLine("El client no existeix.");
            }
        }
    }
}
