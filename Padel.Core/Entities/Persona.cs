using System.ComponentModel.DataAnnotations;

namespace Padel.Core.Entities;

public class Persona
{
    [Required(ErrorMessage = "Il nome è obbligatorio")]
    [StringLength(20, 
        MinimumLength = 3, ErrorMessage = "Il nome deve essere compreso tra 3 e 20 caratteri")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "Il cognome è obbligatorio")]
    [StringLength(20,
        MinimumLength = 3, ErrorMessage = "Il cognome deve essere compreso tra 3 e 20 caratteri")]
    public string? Cognome { get; set; }
    public string? NumeroTelefono { get; set; } = "";
    [EmailAddress(ErrorMessage = "Indirizzo e-mail non valido")]
    public string? Email { get; set; }
    public int Id { get; set; }


    public override string ToString()
    {
        return $"{Nome} {Cognome}";
    }

    public static string NomeInMaiuscolo(string nome)
    {
        return nome.ToUpper();
    }
}
