﻿using Padel.Core.Entities;

//var marioRossi = new GiocatorePadel("Mario", "Rossi");
//var luigiBianchi = new GiocatorePadel("Luigi", "Bianchi", "081755312671672357635");

//var rosaSorrentino = new GiocatorePadel()
//{
//    NumeroTelefono = "8973782347827892",
//    Nome = "Rosa",
//    Cognome = "Sorrentino"
//};

//var pippoFranco = new GiocatorePadel()
//{ Nome = "Pippo", Cognome = "Franco" ,
//  NumeroTelefono = "8973782347827892", 
//  NumeroTessera = "1234567890",
//};

//GiocatorePadel y = new GiocatorePadel();
//GiocatorePadel x = new();
//var z = new GiocatorePadel();

var circolo = new CircoloPadel() {  Nome = "Circolo Padel Napoli" };
circolo.Giocatori.Add(new GiocatorePadel () { Nome = "Mario", Cognome = "Rossi" });
circolo.Istruttori.Add(new IstruttorePadel() { Nome = "Luigi", Cognome = "Bianchi" });





//rosaSorrentino.NumeroTelefono = "hgdhjasgdhjsahd";

//rosaSorrentino.Nome = "Rosina";


//marioRossi.Nome = "Salvatore";
//marioRossi.Cognome = "Sorrentino";

//Console.WriteLine(marioRossi.Nome + " " + marioRossi.Cognome);
//Console.WriteLine($"{marioRossi.Nome} {marioRossi.Cognome}");
//Console.WriteLine(marioRossi.DammiNomeCompleto("*"));
// Console.WriteLine(marioRossi.NumeroTelefono);

Console.WriteLine(rosaSorrentino.DammiNomeCompleto("+"));
Console.WriteLine(pippoFranco.DammiNomeCompleto("+"));



Console.WriteLine("Fine esecuzione del programma");