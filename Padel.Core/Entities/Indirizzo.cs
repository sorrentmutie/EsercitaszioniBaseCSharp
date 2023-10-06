namespace Padel.Core.Entities;

public class Indirizzo
{
    public string Via { get; set; } = "";   
    public string Citta { get; set; } = "";
    public string NumeroCivico { get; set; } = "";
    public string CAP { get; set; } = "";
    public string Provincia { get; set; } = "";
    public string Nazione { get; set; } = "";
    public int Id { get; set; }
}
