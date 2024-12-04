using System.Formats.Asn1;

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
        if(compte==0){
            Console.WriteLine("Tens la compte a 0 xD.");
        }
        else if(compte>=0+dinersARestar){
            compte-=dinersARestar;
        }
        else{
            Console.WriteLine("No tens suficient saldo!");
        }
    }
    public void quantsDiners(){
        Console.WriteLine(compte);
    }
}