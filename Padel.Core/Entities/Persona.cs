namespace Padel.Core.Entities;

public class Persona
{
    public string Nome { get; init; }
    public string Cognome { get; init; }
    public string NumeroTelefono { get; set; }
    public string Email { get; set; }
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
