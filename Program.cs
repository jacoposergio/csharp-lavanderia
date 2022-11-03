// ----------- VARIABILI GLOBALI ------------
//Lavanderia lavanderia = new Lavanderia();



Lavatrice Lavatrice1 = new Lavatrice(1000, 500, true);
public class Lavatrice
{
    public int LivelloDetersivo { get; private set; }
    public int LivelloAmmorbidente { get; private set; }
    public bool InFunzione { get; set; }

    public Lavatrice(int livelloDetersivo, int livelloAmmorbidente, bool inFunzione)
    {
        LivelloDetersivo = livelloDetersivo;
        LivelloAmmorbidente = livelloAmmorbidente;
        InFunzione = inFunzione;
    }
}

public class Lavaggio
{
    public string TipoLavaggio { get; set; }
    public int CostoGettoni { get; set; }
    public int DurataLavaggio { get; set; }

    public int ConsumoDetersivo { get; set; }

    public int ConsumoAmmorbidente { get; set; }

    public Lavaggio (string tipoLavaggio, int costoGettoni, int durataLavaggio, int consumoDetersivo, int consumoAmmorbidente)
    {
        TipoLavaggio = tipoLavaggio;
        CostoGettoni = costoGettoni;
        DurataLavaggio = durataLavaggio;
        ConsumoDetersivo = consumoDetersivo;
        ConsumoAmmorbidente = consumoAmmorbidente;
    }
}
public class Asciugatrice
{

}


//public class Lavanderia
//{

//}