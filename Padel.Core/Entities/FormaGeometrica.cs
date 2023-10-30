namespace Padel.Core.Entities;

public class FormaGeometrica
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Altezza { get; set; }
    public int Larghezza { get; set; }  

    public virtual void Disegna() {         
        Console.WriteLine(
            $"Disegno una forma geometrica in posizione {X} {Y} con altezza {Altezza} e larghezza {Larghezza}");
    }
}

public class Cerchio: FormaGeometrica
{
    public override void Disegna()
    {
        Console.WriteLine("Sto disegnando un cerchio");
      //  base.Disegna();
    }
}

public class Rettangolo: FormaGeometrica
{
    public override void Disegna()
    {
        Console.WriteLine("Sto disegnando un rettangolo");
      //  base.Disegna();
    }
}

public class Quadrato : FormaGeometrica
{
    public override void Disegna()
    {
        Console.WriteLine("Sto disegnando un quadrato");
      //  base.Disegna();
    }
}