
Lavanderia acquaESapone = new Lavanderia();
acquaESapone.StatoLavatrice();


public class Lavanderia
{
    public Lavatrice[] lavatriceArray = new Lavatrice[5];
    public Asciugatrice[] asciugatriceArray = new Asciugatrice[5];
    private object lavaggioArray;

    public Lavanderia()
    {
        for (int i = 0; i < lavatriceArray.Length; i++)
        {
            lavatriceArray[i] = new Lavatrice();
            asciugatriceArray[i] = new Asciugatrice();
        }
    }
    public void StatoLavatrice()
    {
        Console.WriteLine("Stato lavatrici");
        Console.WriteLine("\r\n");

        for (int i = 0; i < lavatriceArray.Length; i++)
        {
            Lavatrice LavatriceCorrente = lavatriceArray[i];
            Console.WriteLine("Informazioni " + LavatriceCorrente + " " + (i + 1));
            Console.WriteLine("Livello detersivo: " + LavatriceCorrente.LivelloDetersivo + " ml");
            Console.WriteLine("Livello ammorbidente: " + LavatriceCorrente.LivelloAmmorbidente + " ml");
            if (LavatriceCorrente.InFunzione)
            {
                Console.WriteLine("Stato: La lavatrice è in funzione");
            }
            else
            Console.WriteLine("Stato: La lavatrice non è in funzione");

            string[] OpzioniLavaggio = { "rinfrescante", "rinnovante", "sgrassante"};
            int indice = new Random().Next(0, OpzioniLavaggio.Length);
            string programmaCorrente = OpzioniLavaggio[indice];
            if (LavatriceCorrente.InFunzione)
            {
                Console.WriteLine("Il programma di lavaggio selezionato è: " + programmaCorrente);
            }
            Console.WriteLine("\r\n");
        }

        Console.WriteLine("Stato asciugatrici");
        Console.WriteLine("\r\n");

        for (int i = 0; i < asciugatriceArray.Length; i++)
        {
            Asciugatrice AsciugatriceCorrente = asciugatriceArray[i];
            Console.WriteLine("Informazioni " + AsciugatriceCorrente + " " + (i + 1));

            if (AsciugatriceCorrente.InFunzione)
            {
                Console.WriteLine("Stato: L'asciugatrice è in funzione");
            }
            else
                Console.WriteLine("Stato: L'asciugatrice non è in funzione");

            string[] OpzioniAsciugatura = { "rapido", "intenso" };
            int indice = new Random().Next(0, OpzioniAsciugatura.Length);
            string programmaCorrente = OpzioniAsciugatura[indice];
            if (AsciugatriceCorrente.InFunzione)
            {
                Console.WriteLine("Il programma di asciugatura selezionato è: " );
            }
            Console.WriteLine("\r\n");
        }
    }

}


public class Lavatrice
{
    public int LivelloDetersivo { get; set; }
    public int LivelloAmmorbidente { get; set; }
    public bool InFunzione { get; set; }

    public Lavaggio[] lavaggioArray { get; set; }


    public Lavatrice()
    {
        LivelloDetersivo = 1000;
        LivelloAmmorbidente = 500;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; 
        InFunzione = randomBool;

        lavaggioArray = new Lavaggio[3];
        lavaggioArray[0] = new Lavaggio("rinfrescante", 2, 20, 20, 5);
        lavaggioArray[1] = new Lavaggio("rinnovante", 3, 40, 40, 10);
        lavaggioArray[2] = new Lavaggio("sgrassante", 4, 60, 60, 15);
    }

}

public class Lavaggio
{
    public string Nome { get; set; }
    public int CostoGettoni { get; set; }
    public int DurataLavaggio { get; set; }

    public int ConsumoDetersivo { get; set; }

    public int ConsumoAmmorbidente { get; set; }

    public Lavaggio (string nome, int costoGettoni, int durataLavaggio, int consumoDetersivo, int consumoAmmorbidente)
    {
        Nome = nome;
        CostoGettoni = costoGettoni;
        DurataLavaggio = durataLavaggio;
        ConsumoDetersivo = consumoDetersivo;
        ConsumoAmmorbidente = consumoAmmorbidente;
    }
}
public class Asciugatrice
{
    public Asciugatura[] asciugaturaArray { get; set; }
    public bool InFunzione { get; set; }

   public Asciugatrice()
    {
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1;
        InFunzione = randomBool;
        asciugaturaArray = new Asciugatura[2];
        asciugaturaArray[0] = new Asciugatura("rapido", 2, 30);
        asciugaturaArray[1] = new Asciugatura("intenso", 4, 60);
    }
 
}

public class Asciugatura
{
    public string Nome { get; set; }
    public int CostoGettoni { get; set; }
    public int DurataAsciugatura { get; set; }

    public Asciugatura(string nome, int costoGettoni, int durataAsciugatura)
    {
        Nome = nome;
        CostoGettoni = costoGettoni;
        DurataAsciugatura = durataAsciugatura;
    }
}

