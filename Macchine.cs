



public abstract class Macchine
{
    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int GuadagnoMacchine { get; set; }

    public Programmi[] programmiArray;

   public Macchine(string nome, bool stato, Programmi programmaSelezionato, Programmi[] programmiArray)
    {
        Nome = nome;
        Stato = stato;
        ProgrammaSelezionato = programmaSelezionato;
        this.programmiArray = programmiArray;
    }
}

