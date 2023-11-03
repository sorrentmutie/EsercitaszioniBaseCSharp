using Padel.Core.Entities;
using Padel.Core.Interfaces;

namespace DemoPadelBlazoirServer.Services;

public class ServizioDatiIstruttoriServer : IDatiIstruttori
{

    private static List<IstruttorePadel> istruttoriDisponibili = new List<IstruttorePadel>()
        {
            new IstruttorePadel { Nome = "Mario", Cognome = "Rossi",
             Id = 1, Email = "mario.rossi@gmail.com", NumeroTelefono = "3331234567",
              Qualifica = "Maestro A", DataAssunzioneIstruttore = new DateTime(2021, 1, 1 )
            },
            new IstruttorePadel { Nome = "Luigi", Cognome = "Bianchi",
             Id = 1, Email = "luigi.bianchi@gmail.com", NumeroTelefono = "1133317",
              Qualifica = "Maestro B", DataAssunzioneIstruttore = new DateTime(2020, 1, 1 )
            },
    };

    private static List<IstruttorePadel> istruttoriNeoAssunti = new List<IstruttorePadel>()
    {
        new IstruttorePadel { Nome = "Giuseppe", Cognome = "Verdi",
            Id = 3, Email = "giuseppe.verdi@gmail.com", NumeroTelefono = "3331234567",
            Qualifica = "Maestro C", DataAssunzioneIstruttore = new DateTime(2023, 1, 1 )
        },
    };


    public void EliminaIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        istruttoriDisponibili.Remove(istruttore);
    }

    public void EliminaIstruttoreNeoAssunto(IstruttorePadel istruttore)
    {
        istruttoriNeoAssunti.Remove(istruttore);
    }

    public List<IstruttorePadel> EstraiIstruttoriDisponibili()
    {
        return istruttoriDisponibili;
    }

    public List<IstruttorePadel> EstraiIstruttoriNeoAssunti()
    {
        return istruttoriNeoAssunti;
    }

    public void ModificaIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        var istruttoreDb = istruttoriDisponibili.FirstOrDefault(x => x.Id == istruttore.Id);
        if (istruttoreDb != null)
        {
            istruttoriDisponibili.Remove(istruttoreDb);
            istruttoriDisponibili.Add(istruttore);
        }
    }

    public void AggiungiIstruttoreDisponibile(IstruttorePadel istruttore)
    {
        var id = 1;
        if (istruttoriDisponibili.Count > 0)
        {
            id = istruttoriDisponibili.Max(i => i.Id) + 1;
        }
        istruttore.Id = id;
        istruttoriDisponibili.Add(istruttore);
    }

}
