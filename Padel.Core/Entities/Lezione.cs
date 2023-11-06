using System.ComponentModel.DataAnnotations;

namespace Padel.Core.Entities;

public class Lezione
{
    public int Id { get; set; }
    public DateTime DataOraInizio { get; set; }
    public DateTime DataOraFine { get; set; }
    [Required(ErrorMessage = "Il numero di campo è obbligatorio")]
    public string Campo { get; set; } = "";
    public int IstruttoreId { get; set; }   
    public IstruttorePadel Istruttore { get; set; } = new();    
}
