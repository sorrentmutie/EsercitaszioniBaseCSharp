using System.Collections;

namespace Padel.Core.Entities;

public class CircoloPadel
{
    public string Nome { get; set; } = "";
    public Indirizzo Indirizzo { get; set; }

    //public GiocatorePadel[] Giocatori { get; set; } = new GiocatorePadel[1000];
    //public IstruttorePadel[] Istruttori { get; set; } = new IstruttorePadel[1000];

    public ArrayList Giocatori { get; set; } = new ArrayList();
    public ArrayList Istruttori { get; set; } = new ArrayList();


    // un circolo ha n giocatori
    // un circolo ha m istruttori

    // var marioRossi = Giocatori[156];
    // SELECT * FROM Giocatori ORDER BY Giocatori.Cognome;
    // SELECT * FROM Giocatori WHERE Giocatori.Cognome = 'Rossi' AND Giocatori.Nome = 'Mario';

}