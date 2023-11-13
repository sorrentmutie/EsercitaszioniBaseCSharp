using Padel.Core.Entities;
using Padel.Core.Interfaces;
using Padel.Core.ViewModels;

namespace DemoPadel.API.Services;

public class ServizioDatiIstruttoriPerAPI : IDatiIstruttori
{
    public void AggiungiIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }

    public Task AggiungiIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }

    public Task AggiungiLezioneAdIstruttoreAsync(int id, LezioneViewModel lezioneViewModel)
    {
        throw new NotImplementedException();
    }

    public void EliminaIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }

    public Task EliminaIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }

    public void EliminaIstruttoreNeoAssunto(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }

    public Task<DettaglioIstruttoreViewModel?> EstraiDettaglioIstruttoreAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IstruttorePadel> EstraiIstruttorePerIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public List<IstruttorePadel> EstraiIstruttoriDisponibili()
    {
        throw new NotImplementedException();
    }

    public Task<List<IstruttorePadel>> EstraiIstruttoriDisponibiliAsync()
    {
        throw new NotImplementedException();
    }

    public List<IstruttorePadel> EstraiIstruttoriNeoAssunti()
    {
        throw new NotImplementedException();
    }

    public void ModificaIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }

    public Task ModificaIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }

    public Task PatchIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        throw new NotImplementedException();
    }
}
