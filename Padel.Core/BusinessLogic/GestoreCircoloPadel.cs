using Padel.Core.Entities;

namespace Padel.Core.BusinessLogic;

public class GestoreCircoloPadel
{
    private Queue<GiocatorePadel> coda = new();
    private Queue<IstruttorePadel> codaIstruttori = new();

    public void AggiungiGiocatoreInCoda(GiocatorePadel giocatorePadel)
    {
        coda.Enqueue(giocatorePadel);
    }

    public void AggiungiNGiocatoriInCoda(int n)
    {
        for (int i = 0; i < n; i++) { 
            coda.Enqueue(new GiocatorePadel() { Nome = $"Nome{i}", Cognome = $"Cognome{i}" });
        }
    }

    public GiocatorePadel? EstraiSpeciale()
    {
        try
        {
            //var primoEstratto = coda.Dequeue() as GiocatorePadel;
            return coda.Dequeue();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public void AggiungiIstruttorePadelInCoda(IstruttorePadel istruttorePadel)
    {
        codaIstruttori.Enqueue(istruttorePadel);
    }


    public GiocatorePadel? EstraiGiocatoreDallaCoda() {

        //var primoEstratto = coda.Dequeue() as GiocatorePadel;
        // var secondoEstratto = (IstruttorePadel)coda.Dequeue();
        return coda.Dequeue();


        //        try
        //        {
        //            var primoEstratto = coda.Dequeue() as GiocatorePadel;
        //            var secondoEstratto = (IstruttorePadel)coda.Dequeue();
        //            return primoEstratto;
        //        }
        //        catch (Exception ex)
        //        {
        // //           Console.WriteLine( ex.Message);
        ////           return null;
        //            throw;
        //        }

    }
}
