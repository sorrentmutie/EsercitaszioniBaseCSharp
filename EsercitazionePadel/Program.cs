using Padel.Core.BusinessLogic;
using Padel.Core.Entities;
using Padel.Core.Interfaces;

IMyConfiguration myConfiguration = new MyConfiguration();
IGestioneCircoliPadel gestione = 
    new GestioneCircoliPadelSuFile(myConfiguration);

gestione.AggiungiCircolo(new CircoloPadel { Id = 3, Nome ="Circolo Roma 1"});
gestione.AggiungiCircolo(new CircoloPadel { Id = 4, Nome = "Circolo Roma 2" });
gestione.AggiungiCircolo(new CircoloPadel { Id = 5, Nome = "Circolo Roma 3" });



var circolo = gestione.CercaPerId(3);
//if(circolo != null)
//{
//    circolo.Nome = "Circolo Roma 1 Modificato";
//    gestione.ModificaCircolo(circolo);
//}

Console.WriteLine("Programma finito");


//var circoli = gestione.EstraiTuttiICircoli();
//foreach (var item in circoli)
//{
//    Console.WriteLine(item.Nome);
//}