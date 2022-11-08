


public class Lavatrici : Macchine
{
    public int QuantitàDiDetersivo { get; set; }
    public int QuantitàDiAmmorbidente { get; set; }
    public int DurataDelLavaggio { get; set; }

    public Lavatrici(string nome, bool stato, Programmi programmaSelezionato, int guadagnoMacchine, Programmi[] programmiArray, int quantitàDiDetersivo, int quantitàDiAmmorbidente, int durataDelLavaggio) : base( nome , stato , programmiArray)
    {
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