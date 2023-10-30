using Padel.Core.Entities;
using System.Collections;

namespace Padel.Core;

public interface ISaluto: IEnumerable
{
    // int B { get; set; }
    string Saluta();
    string SalutaPersona(Persona persona);
    int Somma(int a, int b);
    public int FaQualcosa();
    
}


public abstract class SalutoAstratto
{
    public int MyProperty { get; set; }
    public virtual string Saluta()
    {
        return "Ciao";
    }
    public abstract string SalutaPersona(Persona persona);
    public abstract int Somma(int a, int b);
    //public int FaQualcosa()
    //{
    //    return 0;
    //}
}


public interface IX
{
    int A();   
}

public class X
{
    public int MyProperty { get; set; }
}

public class SalutoATempo : X, ISaluto, IX
{
   // public int B { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int A()
    {
        throw new NotImplementedException();
    }

    public int FaQualcosa()
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public string Saluta()
    {
        if(DateTime.Now.Hour < 12)
            return "Buongiorno";
        else if(DateTime.Now.Hour < 18)
            return "Buon pomeriggio";
        else
            return "Buona sera";
    }

    public string SalutaPersona(Persona persona)
    {
        throw new NotImplementedException();
    }

    public int Somma(int a, int b)
    {
        throw new NotImplementedException();
    }
}


public class SalutoFisso : ISaluto
{
    public int FaQualcosa()
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public string Saluta()
    {
        return "Ciao";
    }

    public string SalutaPersona(Persona persona)
    {
        return $"Ciao, {persona.Nome}";
    }

    public int Somma(int a, int b)
    {
        return a + b;
    }
}

