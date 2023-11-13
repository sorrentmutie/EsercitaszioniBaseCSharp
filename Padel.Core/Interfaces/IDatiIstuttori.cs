using Padel.Core.Entities;
using Padel.Core.ViewModels;

namespace Padel.Core.Interfaces;

public interface IDatiIstruttori
{
    List<IstruttorePadel> EstraiIstruttoriDisponibili();
    List<IstruttorePadel> EstraiIstruttoriNeoAssunti();
    void EliminaIstruttoreDisponibile(IstruttorePadel istruttore);
    void EliminaIstruttoreNeoAssunto(IstruttorePadel istruttore);
    void AggiungiIstruttoreDisponibile(IstruttorePadel istruttore);
    void ModificaIstruttoreDisponibile(IstruttorePadel istruttore);

    Task<List<IstruttorePadel>> EstraiIstruttoriDisponibiliAsync();
    Task EliminaIstruttoreDisponibileAsync(IstruttorePadel istruttore);
    Task AggiungiIstruttoreDisponibileAsync(IstruttorePadel istruttore);
    Task ModificaIstruttoreDisponibileAsync(IstruttorePadel istruttore);
    Task<IstruttorePadel?> EstraiIstruttorePerIdAsync(int id);
    Task PatchIstruttoreDisponibileAsync(IstruttorePadel istruttore);


    Task<DettaglioIstruttoreViewModel?> EstraiDettaglioIstruttoreAsync(int id);
    Task AggiungiLezioneAdIstruttoreAsync(int id, LezioneViewModel lezioneViewModel);
}
