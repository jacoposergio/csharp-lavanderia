



public class Asciugatrici
{
    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int DurataDelLavaggio { get; set; }

    public int GuadagnoMacchine { get; set; }

    public Programmi[] programmiArray;

    public Asciugatrici(string nome, bool stato, Programmi programmaSelezionato, int durataDelLavaggio)
    {
        Nome = nome;
        Stato = stato;
        ProgrammaSelezionato = programmaSelezionato;
        DurataDelLavaggio = durataDelLavaggio;

        programmiArray = new Programmi[2];
        programmiArray[0] = new Programmi("Intenso", 4, 20, 0, 0);
        programmiArray[1] = new Programmi("Rapido", 2, 20, 0, 0); ;
    }

    public void programmaRandom()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, programmiArray.Length);
        ProgrammaSelezionato = programmiArray[randomNumber];
        GuadagnoMacchine += ProgrammaSelezionato.Costo;

    }
}

