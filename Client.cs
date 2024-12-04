namespace Banquer;

class Client
{
    private string nom;
    private int compte = 0;

    public Client()
    {
        nom="";
        compte=0;
    }

    public Client(string nom){
        this.nom = nom;
        compte = 0;
    }
    public Client(string nom, int saldoInicial){
        this.nom = nom;
        compte = saldoInicial;
    }
    public string Nom{
        get{return nom;}
    }
    public int Compte{
        get{return compte;}
    }

    public void posarDiners(){
        Console.WriteLine("Quants diners vols afegir?");
        int dinersASumar = int.Parse(Console.ReadLine());

        if(dinersASumar>0){
            compte+=dinersASumar;
        }
        else{
            Console.WriteLine("No pots afegir un saldo negatiu!");
        }
    }
    public void treureDiners(){
        Console.WriteLine("Quants diners vols treure?");
        int dinersARestar = int.Parse(Console.ReadLine());
        int comissio = compte/100;
        if(compte==0){
            Console.WriteLine("Tens la compte a 0 xD.");
        }
        else if(compte+comissio>=0+dinersARestar){
            compte-=comissio;
            compte-=dinersARestar;
        }
        else{
            Console.WriteLine("No tens suficient saldo! Recorda que has de poder treure els diners un cop feta la comissió.");
        }
    }
    public void quantsDiners(){
        Console.WriteLine(compte);
    }
}

public string TreureDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = quantitat / 100;
            if (quantitat + comissio > client.Saldo)
            {
                return $"No tens {quantitat+comissio} ouros prou diners";
            }
            client.Saldo -= quantitat + comissio;
            return $"Té {quantitat} euros et queden {client.Saldo}";
        }
        return $"Tu no ets client {nomClient}";
    }