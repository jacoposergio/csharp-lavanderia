// ----------- VARIABILI GLOBALI ------------

Lavanderia acquaESapone = new Lavanderia();
acquaESapone.Stampa();


public class Lavanderia
{
    public Lavatrice[] lavatriceArray = new Lavatrice[5];
    public Asciugatrice[] asciugatriceArray = new Asciugatrice[5];

    public Lavanderia()
    {
        for (int i = 0; i < lavatriceArray.Length; i++)
        {
            lavatriceArray[i] = new Lavatrice();
            asciugatriceArray[i] = new Asciugatrice();
        }
    }
    public void Stampa()
    {
        for(int i = 0; i < lavatriceArray.Length; i++)
        {
            Lavatrice nuovaLavatrice = lavatriceArray[i];
            Console.WriteLine(nuovaLavatrice.LivelloDetersivo);
        }
    }

}


public class Lavatrice
{
    public int LivelloDetersivo { get; set; }
    public int LivelloAmmorbidente { get; set; }
    public bool InFunzione { get; set; }

    Lavaggio Lavaggio { get; set; }
    public Lavatrice()
    {
        LivelloDetersivo = 1000;
        LivelloAmmorbidente = 500;
        InFunzione = false;
        Lavaggio = Rinfrescante;
    }

    Lavaggio Rinfrescante = new Lavaggio(2, 20, 20, 5);
    Lavaggio Rinnovante = new Lavaggio(3, 40, 40, 10);
    Lavaggio Sgrassante = new Lavaggio(4, 60, 60, 15);
}

public class Lavaggio
{
    public int CostoGettoni { get; set; }
    public int DurataLavaggio { get; set; }

    public int ConsumoDetersivo { get; set; }

    public int ConsumoAmmorbidente { get; set; }

    public Lavaggio (int costoGettoni, int durataLavaggio, int consumoDetersivo, int consumoAmmorbidente)
    {       
        CostoGettoni = costoGettoni;
        DurataLavaggio = durataLavaggio;
        ConsumoDetersivo = consumoDetersivo;
        ConsumoAmmorbidente = consumoAmmorbidente;
    }
}
public class Asciugatrice
{
    public bool InFunzione { get; set; }

    Asciugatura Rapido = new Asciugatura(2, 30);
    Asciugatura Intenso = new Asciugatura(4, 60);
}

public class Asciugatura
{
    public int CostoGettoni { get; set; }
    public int DurataAsciugatura { get; set; }

    public Asciugatura(int costoGettoni, int durataAsciugatura)
    {
        CostoGettoni = costoGettoni;
        DurataAsciugatura = durataAsciugatura;
    }
}

