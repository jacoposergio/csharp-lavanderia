



public abstract class Macchine
{
    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int GuadagnoMacchine { get; set; }

    public int DurataDelLavaggio { get; set; }

    public Programmi[] programmiArray;

    public Macchine(string nome, bool stato, Programmi programmaSelezionato, int guadagnoMacchine, int durataDelLavaggio)
    {
        Nome = nome;
        Stato = stato;
        ProgrammaSelezionato = programmaSelezionato;
        DurataDelLavaggio = durataDelLavaggio;
    }

    public virtual void programmaRandom()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, programmiArray.Length);
        ProgrammaSelezionato = programmiArray[randomNumber];
        GuadagnoMacchine += ProgrammaSelezionato.Costo;
    }

}


//////////////////////////////////////////////////////////////