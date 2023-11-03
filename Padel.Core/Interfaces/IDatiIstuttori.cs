using Padel.Core.Entities;

namespace Padel.Core.Interfaces;

public interface IDatiIstruttori
{
    List<IstruttorePadel> EstraiIstruttoriDisponibili();
    List<IstruttorePadel> EstraiIstruttoriNeoAssunti();
    void EliminaIstruttoreDisponibile(IstruttorePadel istruttore);
    void EliminaIstruttoreNeoAssunto(IstruttorePadel istruttore);
    void AggiungiIstruttoreDisponibile(IstruttorePadel istruttore);
    void ModificaIstruttoreDisponibile(IstruttorePadel istruttore);
}
