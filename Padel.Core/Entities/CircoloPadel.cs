using System.Collections;

namespace Padel.Core.Entities;

public class CircoloPadelGenerico<T,U>
{
    public string Nome { get; set; } = "";
    public Indirizzo? Indirizzo { get; set; }
    public List<T>? Persone { get; set; }
    public List<U>? AltrePersone { get; set; }

    public CircoloPadelGenerico()
    {
        Persone = new List<T>();
        AltrePersone = new List<U>();
    }

    public void AggiungiPersona(T persona)
    {
        Persone?.Add(persona);
    }

    public void AggiungiAltraPersona(U persona)
    {
        AltrePersone?.Add(persona);
    }
}



public class CircoloPadel
{
    public string Nome { get; set; } = "";
    public Indirizzo? Indirizzo { get; set; }
    public int Id { get; set; }

  
    //public GiocatorePadel[] Giocatori { get; set; } = new GiocatorePadel[1000];
    //public IstruttorePadel[] Istruttori { get; set; } = new IstruttorePadel[1000];

    public List<GiocatorePadel>? Giocatori { get; set; }  
    public List<IstruttorePadel>? Istruttori { get; set; }  


    // un circolo ha n giocatori
    // un circolo ha m istruttori

    // var marioRossi = Giocatori[156];
    // SELECT * FROM Giocatori ORDER BY Giocatori.Cognome;
    // SELECT * FROM Giocatori WHERE Giocatori.Cognome = 'Rossi' AND Giocatori.Nome = 'Mario';

}