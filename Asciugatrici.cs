



public class Asciugatrici : Macchine
{

    public Asciugatrici(string nome, bool stato, Programmi programmaSelezionato, int guadagnoMacchine, int durataDelLavaggio) : base(nome, stato, programmaSelezionato, guadagnoMacchine, durataDelLavaggio)
    {
        programmiArray = new Programmi[2];
        programmiArray[0] = new Programmi("Intenso", 4, 20, 0, 0);
        programmiArray[1] = new Programmi("Rapido", 2, 20, 0, 0); ;
    }

    //public override void programmaRandom()
    //{
    //    //Random rnd = new Random();
    //    //int randomNumber = rnd.Next(0, programmiArray.Length);
    //    //ProgrammaSelezionato = programmiArray[randomNumber];
    //    //GuadagnoMacchine += ProgrammaSelezionato.Costo;
    //}
}




///////////////////////////////   ///////////////////////////////////  

