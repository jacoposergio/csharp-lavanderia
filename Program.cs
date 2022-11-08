
Lavanderia acquaESapone = new Lavanderia();


    Console.WriteLine("1. Stato macchine");
    Console.WriteLine("2. Dettagli macchine");
    Console.WriteLine("3. Incasso macchine");
    int risposta = Convert.ToInt32(Console.ReadLine());

    switch (risposta)
    {
        case 1:
            acquaESapone.CercaMacchine();
            break;
        case 2:
            acquaESapone.StatoMacchine();
            break;
        case 3:
            Console.WriteLine(acquaESapone.Saldo() + "euro");
            break;
        default:
            Console.WriteLine("Sei capace di premere un tasto?");
            break;   
}

