namespace Padel.Core.Entities;

public class Persona
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
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
