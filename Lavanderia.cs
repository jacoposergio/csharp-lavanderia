
public class Lavanderia
{
    private Lavatrici[] lavatriciArray;
    private Asciugatrici[] asciugatriciArray;

    public Lavanderia()
    {
        lavatriciArray = new Lavatrici[5];
        asciugatriciArray = new Asciugatrici[5];

        for (int i = 0; i < 5; i++)
        {
            lavatriciArray[i] = new Lavatrici("Lavatrice " + (i + 1), true, null, 1000, 500, 0, 0);
            lavatriciArray[i].programmaRandom();
        }
        for (int i = 0; i < 5; i++)
        {
            asciugatriciArray[i] = new Asciugatrici("Asciugatrice " + (i + 1), true, null, 1,1);
            asciugatriciArray[i].programmaRandom();
        }
    }

    public void CercaMacchine()
    {
        Console.WriteLine("Tutte le lavatrici");
        for (int i = 0; i < lavatriciArray.Length; i++)
        {
            if (lavatriciArray[i].Stato)
            {
                Console.WriteLine(lavatriciArray[i].Nome + "in lavaggio");
            }
            else
            {
                Console.WriteLine(lavatriciArray[i].Nome + "non in funzione");
            }
        }
        Console.WriteLine("Tutte le asciugatrici");
        for (int i = 0; i < asciugatriciArray.Length; i++)
        {
            if (asciugatriciArray[i].Stato)
            {
                Console.WriteLine(asciugatriciArray[i].Nome + "in lavaggio");
            }
            else
            {
                Console.WriteLine(asciugatriciArray[i].Nome + "non in funzione");
            }
        }
    }

    public void StatoMacchine()
    {
        Console.WriteLine("Seleziona una macchina");
        Console.WriteLine("1) Lavatrice");
        Console.WriteLine("2) Asciugatrice");
        int risposta = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("seleziona la macchine \r\n");
        int macchinaSelezionata = Convert.ToInt32(Console.ReadLine());
        if (risposta == 1)
        {

            Console.WriteLine(lavatriciArray[macchinaSelezionata - 1].Nome);
            if (lavatriciArray[macchinaSelezionata - 1].Stato)
            {
                Console.WriteLine("Stato: in lavaggio");
            }
            else
            {
                Console.WriteLine("Stato: non in funzione");
            }        
            Console.WriteLine("Programma selezionato : " + lavatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Tipo);
            Console.WriteLine("Programma durata : " + lavatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Durata);
            Random rnd = new Random();
            int tempo = rnd.Next(1, lavatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Durata);
            Console.WriteLine("Tempo rimanente : " + (lavatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Durata - tempo) + " min");          
            Console.WriteLine("Quantità di detersivo rimanente : " + lavatriciArray[macchinaSelezionata - 1].QuantitàDiDetersivo);
    
        }
        else
        {
            Console.WriteLine(asciugatriciArray[macchinaSelezionata - 1].Nome);


            if (asciugatriciArray[macchinaSelezionata - 1].Stato)
            {
                Console.WriteLine("Stato: in asciugatura");
            }
            else
            {
                Console.WriteLine("Stato: non in funzione");
            }
            Console.WriteLine("Programma selezionato : " + asciugatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Tipo);
            Console.WriteLine("Programma durata : " + asciugatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Durata);
            Random rnd = new Random();
            int tempo = rnd.Next(1, asciugatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Durata);
            Console.WriteLine("Tempo rimanente : " + (asciugatriciArray[macchinaSelezionata - 1].ProgrammaSelezionato.Durata - tempo) + " min");
        }

    }
    public float Saldo()
    {
        int saldo = 0;
        for (int i = 0; i < lavatriciArray.Length; i++)
        {
            saldo += lavatriciArray[i].GuadagnoMacchine;
            saldo += asciugatriciArray[i].GuadagnoMacchine;
        }

        return saldo / 2;
    }
}

