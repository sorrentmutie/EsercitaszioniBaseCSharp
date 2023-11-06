namespace Padel.Core.ViewModels;

public class DettaglioIstruttoreViewModel
{
    public int Id { get; set; } 
    public string NomeCompleto { get; set; } = "";
    public string? Email { get; set; } = "";
    public string? NumeroTelefono { get; set; } = "";
    public string? Foto { get; set; } = "";
    public List<LezioneViewModel> Lezioni { get; set; } = new();
}

public class LezioneViewModel {
    public int Id { get; set; }
    public DateTime DataOraInizio { get; set; }
    public DateTime DataOraFine { get; set; }
    public string Campo { get; set; } = ""; 
}