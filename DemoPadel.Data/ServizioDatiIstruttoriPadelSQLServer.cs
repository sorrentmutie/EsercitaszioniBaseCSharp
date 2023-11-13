using Microsoft.EntityFrameworkCore;
using Padel.Core.Entities;
using Padel.Core.Interfaces;
using Padel.Core.ViewModels;

namespace DemoPadel.Data;

public class ServizioDatiIstruttoriPadelSQLServer : IDatiIstruttori
{
    private readonly PadelDataContext padelDataContext;

    public ServizioDatiIstruttoriPadelSQLServer(PadelDataContext padelDataContext)
    {
        this.padelDataContext = padelDataContext;
    }

    public void AggiungiIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        istruttore.Disponibile = true;
        padelDataContext.IstruttoriPadel.Add(istruttore);
        padelDataContext.SaveChanges();
    }

    public async Task AggiungiIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        istruttore.Disponibile = true;
        padelDataContext.IstruttoriPadel.Add(istruttore);
        await padelDataContext.SaveChangesAsync();
    }

    public async Task AggiungiLezioneAdIstruttoreAsync(int id, LezioneViewModel lezioneViewModel)
    {

        var istruttore = await padelDataContext.IstruttoriPadel.FindAsync(id);
        if(istruttore == null) return;

        istruttore.Lezioni.Add(
           new Lezione
           {
                Campo = lezioneViewModel.Campo,
                DataOraInizio = lezioneViewModel.DataOraInizio,
                DataOraFine = lezioneViewModel.DataOraFine,
                IstruttoreId = id
           });
            await padelDataContext.SaveChangesAsync();
    }

    public void EliminaIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        if(istruttore.Disponibile == true)
        {
            padelDataContext.Entry(istruttore).State = EntityState.Deleted;
            padelDataContext.SaveChanges();
        }
    }

    public async Task EliminaIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        if (istruttore.Disponibile == true)
        {
            padelDataContext.Entry(istruttore).State = EntityState.Deleted;
            await padelDataContext.SaveChangesAsync();
        }
    }

    public void EliminaIstruttoreNeoAssunto(IstruttorePadel istruttore)
    {
        padelDataContext.Entry(istruttore).State = EntityState.Deleted;
        padelDataContext.SaveChanges();
    }

    public async Task<DettaglioIstruttoreViewModel?> 
        EstraiDettaglioIstruttoreAsync(int id)
    {
        var dettaglio = new DettaglioIstruttoreViewModel();

        var istruttore = await padelDataContext.IstruttoriPadel
            .Include(i => i.Lezioni)
            .Where(i => i.Id == id).FirstOrDefaultAsync();

        if(istruttore == null) return null;
        dettaglio.Foto = istruttore.Foto;   
        dettaglio.Email = istruttore.Email;
        dettaglio.NumeroTelefono = istruttore.NumeroTelefono;
        dettaglio.NomeCompleto = $"{istruttore.Nome} {istruttore.Cognome}";
        dettaglio.Id = istruttore.Id;
        dettaglio.Lezioni = istruttore.Lezioni
             .Select(l => new LezioneViewModel
             {
                Id = l.Id,
                Campo = l.Campo,
                DataOraInizio = l.DataOraInizio,
                DataOraFine = l.DataOraFine
            }).ToList();
        return dettaglio;
    }

    public async Task<IstruttorePadel?> EstraiIstruttorePerIdAsync(int id)
    {
        var istruttore = await padelDataContext.IstruttoriPadel.FindAsync(id);
        if(istruttore == null) return null;
        padelDataContext.Entry(istruttore).State = EntityState.Detached;    
        return istruttore;
    }

    public List<IstruttorePadel> EstraiIstruttoriDisponibili()
    {
        return padelDataContext.IstruttoriPadel.Where(x=> x.Disponibile == true).ToList();
    }

    public async Task<List<IstruttorePadel>> EstraiIstruttoriDisponibiliAsync()
    {
        return await 
            padelDataContext.IstruttoriPadel.Where(x => x.Disponibile == true).ToListAsync();
    }

    public List<IstruttorePadel> EstraiIstruttoriNeoAssunti()
    {
        var dataLimite = DateTime.Today.AddYears(-1);
        return padelDataContext.IstruttoriPadel
            .Where(i => i.DataAssunzioneIstruttore >= dataLimite).ToList();
    }

    public void ModificaIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        if(istruttore.Disponibile == true)
        {
            padelDataContext.Entry(istruttore).State = EntityState.Modified;
            padelDataContext.SaveChanges();
        }
    }

    public async Task ModificaIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        if (istruttore.Disponibile == true)
        {
            padelDataContext.Entry(istruttore).State = EntityState.Modified;
            await padelDataContext.SaveChangesAsync();
        }
    }

    public async Task PatchIstruttoreDisponibileAsync(IstruttorePadel istruttore)
    {
        var istruttoreDb = await padelDataContext.IstruttoriPadel.FindAsync(istruttore.Id);
        if(istruttoreDb == null) return;
        if(istruttore.Nome != null) istruttoreDb.Nome = istruttore.Nome;
        if(istruttore.Cognome != null) istruttoreDb.Cognome = istruttore.Cognome;
        if(istruttore.Email != null) istruttoreDb.Email = istruttore.Email;
        await padelDataContext.SaveChangesAsync();
    }
}
