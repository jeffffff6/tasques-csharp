namespace Banquer;

class Banquer
{
    private List<Client> clients = new List<Client>();
    public void CrearClient()
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
    public void ConsultarClient()
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
    public void OperarClient(){
        
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