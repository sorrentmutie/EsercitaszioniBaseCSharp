using Padel.Core;
using Padel.Core.BusinessLogic;
using Padel.Core.Entities;
using Padel.Core.Extensions;
using Padel.Core.Helpers;
using Padel.Core.Interfaces;

//Console.WriteLine("Fine esecuzione del programma");
//var mario = new Persona { Nome = "Mario", Cognome = "Rossi" };

//var nomeMaiuscolo = HelperPersona.NomeInMaiuscolo("Mario");
//Console.WriteLine(nomeMaiuscolo);

//var secondoNomeMaiuscolo = Persona.NomeInMaiuscolo("Mario");

//var cerchio = new Cerchio { X = 1, Y = 2 };
//cerchio.Disegna();


//var forme = new List<FormaGeometrica>();
//forme.Add(new Cerchio { X = 1, Y = 2 });
//forme.Add(new Rettangolo { X = 1, Y = 2 });
//forme.Add(new Quadrato { X = 1, Y = 2 });

//foreach (FormaGeometrica forma in forme)
//{
//    //Cerchio? x = forma as Cerchio;

//    //Cerchio x = (Cerchio)forma;


//    //x?.Disegna();
//    if (forma is Cerchio)
//    {
//        Cerchio x = (Cerchio)forma;
//        x.Disegna();
//    }



//    forma.Disegna();
//}

//ISaluto saluto = new SalutoATempo();
//saluto.Saluta();

var circolo1 = new CircoloPadelGenerico<GiocatorePadel, IstruttorePadel>(); 
circolo1.Nome = "Circolo 1";
circolo1.Indirizzo = new Indirizzo { Via = "Via Roma", NumeroCivico = "1", Citta = "Roma" };
circolo1.AggiungiPersona(new GiocatorePadel { Nome = "Mario", Cognome = "Rossi" });

var circolo2 = new CircoloPadelGenerico<IstruttorePadel, GiocatorePadel>();


// IGestioneCircoliPadel gestioneSuDb = new GestioneCircoliPadelSuDatabase();

Func<int,bool> funzione = NumeroPari;
Func<string, bool> func = MiaSelezione;

bool NumeroPari(int n)
{
    return n % 2 == 0;
}

//bool NumeroDispari(int n)
//{
//    return n % 2 != 0;
//}

bool MiaSelezione(string s)
{
    return s.StartsWith("M");
}


var lista = new List<int> { 1, 2, 3, 4, 5 };
// var x = lista.FindAll(NumeroDispari);
//var z = lista.FindAll(delegate(int n) { return n % 2 != 0; });
var z = lista.FindAll(n => n % 2 == 0);


// = >

var listaStringhe = new List<string>
{
    "Mario", "Luigi", "Giovanni", "Giacomo"
};

var listaSpeciale = listaStringhe.MioMetodoSpeciale(5);


var persona = new Persona { Cognome = "Sorrentino", Nome = "Salvatore" };
var x = persona.NomeIniziaCon("S");


//var y = listaStringhe.FindAll(MiaSelezione);
//var y1= listaStringhe.FindAll(s => s.StartsWith("M"));

////IGestioneGenerica<GiocatorePadel> gestione2;
//var dizionario = new Dictionary<int, string>() ;
//Dictionary<int, string> dizionario2 = new();

//var x = new  { Nome = "Mario", Cognome = "Rossi", Eta = 30 };
//// x.Pippo = 12;
///
using IGestioneCircoliPadel gestione = new GestioneCircoliPadelSuFile();
gestione.AggiungiCircolo(new CircoloPadel { Id = 3, Nome ="Circolo Roma 1"});
gestione.AggiungiCircolo(new CircoloPadel { Id = 4, Nome = "Circolo Roma 2" });
gestione.AggiungiCircolo(new CircoloPadel { Id = 5, Nome = "Circolo Roma 3" });

Console.WriteLine("Programma finito");
//var circolo = gestione.CercaPerId(3);
//if(circolo != null)
//{
//    circolo.Nome = "Circolo Roma 1 Modificato";
//    gestione.ModificaCircolo(circolo);
//}

//var circoli = gestione.EstraiTuttiICircoli();
//foreach (var item in circoli)
//{
//    Console.WriteLine(item.Nome);
//}