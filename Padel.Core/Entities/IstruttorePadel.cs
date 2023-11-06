namespace Padel.Core.Entities;

public class IstruttorePadel: Persona
{
    public DateTime DataAssunzioneIstruttore { get; set; }
    public string? Qualifica { get; set; } = "";
    public bool Disponibile { get; set; }
    public List<Lezione> Lezioni { get; set; } = new();
    public string? Foto { get; set; } = "";
}
