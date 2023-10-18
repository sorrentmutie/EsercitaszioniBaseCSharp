
using Padel.Core.BusinessLogic;
using Padel.Core.Entities;
using System.Collections;

namespace EsercitazionePadel;

internal class Lezione_1
{
    public Lezione_1()
    {
        //var circolo = new CircoloPadel() {  Nome = "Circolo Padel Napoli" };
        //circolo.Giocatori.Add(new GiocatorePadel () { Nome = "Mario", Cognome = "Rossi" });
        //circolo.Istruttori.Add(new IstruttorePadel() { Nome = "Luigi", Cognome = "Bianchi" });


        var lista = new ArrayList();
        lista.Add(new GiocatorePadel() { Nome = "Mario", Cognome = "Rossi" });
        lista.Add(new IstruttorePadel() { Nome = "Luigi", Cognome = "Bianchi" });



        Hashtable tabella = new Hashtable();
        tabella.Add(1, new GiocatorePadel() { Nome = "Mario", Cognome = "Rossi" });
        tabella[2] = new GiocatorePadel() { Nome = "Luigi", Cognome = "Bianchi" };
        //



        bool esiste = tabella.ContainsKey(1);
        Console.WriteLine(esiste);
        Console.WriteLine($"Numero elementi nell'hashtable: {tabella.Count}");
        if (esiste == true)
        {
            Console.WriteLine("Chiave già esistente");
        }
        else
        {
            tabella.Add(1, new GiocatorePadel() { Nome = "Maria", Cognome = "Rossi" });
        }





        //var codaGiocatori = new Queue();

        //for (int i = 0; i < 100; i++)
        //{
        //    codaGiocatori.Enqueue(new GiocatorePadel() { Nome =$"Nome{i}", Cognome = $"Cognome{i}" });
        //}

        //codaGiocatori.Enqueue(new GiocatorePadel() { Nome = "Mario", Cognome = "Rossi" });
        //codaGiocatori.Enqueue(42);

        //var primoEstratto = codaGiocatori.Dequeue() as IstruttorePadel;
        //if (primoEstratto != null)
        //{
        //    Console.WriteLine($"{primoEstratto.Qualifica}");
        //}

        //try
        //{
        //    var secondoEstratto = (IstruttorePadel)codaGiocatori.Dequeue();

        //    if (secondoEstratto != null)
        //    {
        //        Console.WriteLine($"{secondoEstratto.Qualifica}");
        //    }
        //}
        //catch(InvalidCastException ex)
        //{
        //    Console.WriteLine($"Errore nel cast: {ex.Message}");
        //}
        //catch(NullReferenceException ex)
        //{
        //    Console.WriteLine($"Errore nel cast: {ex.Message}");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"{ex.Message}");
        //}


        var gestore = new GestoreCircoloPadel();
        gestore.AggiungiIstruttorePadelInCoda(new IstruttorePadel() { Nome = "Giuseppe", Cognome = "Verdi" });
        gestore.AggiungiNGiocatoriInCoda(100);
        gestore.AggiungiGiocatoreInCoda(new GiocatorePadel() { Nome = "Mario", Cognome = "Rossi" });
        gestore.AggiungiGiocatoreInCoda(new GiocatorePadel() { Nome = "Luigi", Cognome = "Bianchi" });


        var gestoreGiocatori = new GestoreGenerico<GiocatorePadel>();
        var gestoreIstruttori = new GestoreGenerico<IstruttorePadel>();
        var gestoreNumeri = new GestoreGenerico<int>();
        //var gestoreStringhe = new GestoreGenerico<String>();

        gestoreNumeri.AggiungiElementoInCoda(1);
        gestoreNumeri.AggiungiElementoInCoda(2);
        gestoreGiocatori.AggiungiElementoInCoda(new GiocatorePadel() { Nome = "Mario", Cognome = "Rossi" });
        gestoreIstruttori.AggiungiElementoInCoda(new IstruttorePadel() { Nome = "Mario", Cognome = "Rossi" });


        //var lista2 = new ArrayList();
        //lista2.Add(1);
        //lista2.Add("Ciao");

        //var pad = new GiocatorePadel() { Nome = "Mario", Cognome = "Rossi" };
        //Console.WriteLine(pad.ToString());
        //lista2.Add(pad);

        //foreach (var item in lista2)
        //{
        //    Console.WriteLine($"{item}");
        //}


        //try
        //{
        //    var primoEstratto = gestore.EstraiGiocatoreDallaCoda();
        //    Console.WriteLine($"Giocatore Estratto: {primoEstratto?.Nome}");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        var circoloNapoli = new CircoloPadel { Nome = "Circolo Padel Napoli" };
        circoloNapoli.Istruttori = new List<IstruttorePadel>();
        circoloNapoli.Giocatori = new List<GiocatorePadel>();

        var dizionario = new Dictionary<string, GiocatorePadel>();


        circoloNapoli.Istruttori?.Add(new IstruttorePadel() { Nome = "Mario", Cognome = "Rossi" });
        for (int i = 0; i < 10; i++)
        {
            //circoloNapoli.Giocatori?.Add(new GiocatorePadel() { Nome = $"{i}" });
            dizionario.Add(i.ToString(), new GiocatorePadel() { Nome = $"{i}" });
        }
        // circoloNapoli.Giocatori?.Add(new GiocatorePadel() { Nome = "Luigi" });
        dizionario.Add("Luigi", new GiocatorePadel() { Nome = "Luigi" });


        var inizio = DateTime.Now;
        if (dizionario.ContainsKey("597800"))
        {
            Console.WriteLine("Trovato Luigi");
            var luigi = dizionario["597800"];
        }
        var fine = DateTime.Now;
        var tempoTotale = (fine - inizio).TotalMilliseconds;
        Console.WriteLine(tempoTotale);



        //var inizio = DateTime.Now;
        //if(circoloNapoli.Giocatori != null)
        //{
        //    foreach (var giocatore in circoloNapoli.Giocatori)
        //    {
        //        if(giocatore.Nome == "Luigi")
        //        {
        //            Console.WriteLine("Trovato Luigi");
        //        }   
        //    }
        //}
        //var fine = DateTime.Now;
        //var tempoTotale = (fine - inizio).TotalSeconds;
        //Console.WriteLine(tempoTotale);




        //Console.WriteLine($"{circoloNapoli.Istruttori?.Count}");

        var dizionarioComuniItaliani = new Dictionary<int, string>();
        dizionarioComuniItaliani.Add(1, "Napoli");
        dizionarioComuniItaliani.Add(2, "Roma");
        dizionarioComuniItaliani.Add(3, "Milano");
        dizionarioComuniItaliani.Add(4, "Torino");


        var comune = dizionarioComuniItaliani[3];
        Console.WriteLine(comune);


        var circoloPadelGenerico = new CircoloPadelGenerico<GiocatorePadel, IstruttorePadel>();
        var circoloPadelGenerico2 = new CircoloPadelGenerico<GiocatorePadel, OperatoreManutenzione>();
        var circoloPadelGenerico3 = new CircoloPadelGenerico<IstruttorePadel, OperatoreManutenzione>();


        var a = 1;
        var b = 2;

        var x = a < b;
        Console.WriteLine(x);

        var c = "albicocca";
        var d = "banana";
        var y = c.CompareTo(c);


        var helper = new Helper<int>();
        helper.MyMax(a, b);

        var helper2 = new Helper<string>();
        helper2.MyMax(c, d);

        //var helper3 = new Helper<GiocatorePadel>();


        Console.WriteLine(y);

    }
}
