

public class Programmi
{
    public int Costo { get; set; }
    public int Durata { get; set; }
    public int ConsumoDetersivo { get; set; }
    public int ConsumoAmmorbidente { get; set; }
    public string Tipo { get; }

    public Programmi(string tipo, int costo, int durata, int consumoDetersivo, int consumoAmmorbidente)
    {
        Tipo = tipo;
        Costo = costo;
        Durata = durata;
        ConsumoDetersivo = consumoDetersivo;
        ConsumoAmmorbidente = consumoAmmorbidente;
    }

}