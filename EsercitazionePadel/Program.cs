using Padel.Core.Entities;

var circolo = new CircoloPadel() {  Nome = "Circolo Padel Napoli" };
circolo.Giocatori.Add(new GiocatorePadel () { Nome = "Mario", Cognome = "Rossi" });
circolo.Istruttori.Add(new IstruttorePadel() { Nome = "Luigi", Cognome = "Bianchi" });


Console.WriteLine("Fine esecuzione del programma");