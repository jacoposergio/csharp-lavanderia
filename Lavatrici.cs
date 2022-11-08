


public class Lavatrici
{

    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int QuantitàDiDetersivo { get; set; }
    public int QuantitàDiAmmorbidente { get; set; }
    public int DurataDelLavaggio { get; set; }
    public int GuadagnoMacchine { get; set; }

    public Programmi[] programmiArray;
    public Lavatrici(string nome, bool stato, Programmi programmaSelezionato, int quantitàDiDetersivo, int quantitàDiAmmorbidente, int durataDelLavaggio)
    {
        Nome = nome;
        Stato = stato;
        ProgrammaSelezionato = programmaSelezionato;
        QuantitàDiDetersivo = quantitàDiDetersivo;
        QuantitàDiAmmorbidente = quantitàDiAmmorbidente;
        DurataDelLavaggio = durataDelLavaggio;

        programmiArray = new Programmi[3];
        programmiArray[0] = new Programmi("Rinfrescante", 2, 20, 20, 5);
        programmiArray[1] = new Programmi("Rinnovante", 3, 40, 40, 10);
        programmiArray[2] = new Programmi("Sgrassante", 4, 60, 60, 15);
    }

    public void programmaRandom()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, programmiArray.Length);
        ProgrammaSelezionato = programmiArray[randomNumber];
        GuadagnoMacchine += ProgrammaSelezionato.Costo;
        QuantitàDiDetersivo -= ProgrammaSelezionato.ConsumoDetersivo;
        QuantitàDiAmmorbidente -= ProgrammaSelezionato.ConsumoAmmorbidente;
    }
}