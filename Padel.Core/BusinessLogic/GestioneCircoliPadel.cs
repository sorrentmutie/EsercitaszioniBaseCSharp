using Padel.Core.Entities;
using Padel.Core.Interfaces;

namespace Padel.Core.BusinessLogic;

public class GestioneCircoliPadelSuDatabase : IGestioneCircoliPadel
{
    public bool AggiungiCircolo(CircoloPadel circolo)
    {
        throw new NotImplementedException();
    }

    public List<CircoloPadel> Cerca(string ricerca)
    {
        throw new NotImplementedException();
    }

    public CircoloPadel? CercaPerId(int id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void EliminaCircolo(int id)
    {
        throw new NotImplementedException();
    }

    public List<CircoloPadel> EstraiTuttiICircoli()
    {
        throw new NotImplementedException();
    }

    public void ModificaCircolo(CircoloPadel circolo)
    {
        throw new NotImplementedException();
    }
}


public class GestioneCircoliPadelSuFile : IGestioneCircoliPadel
{
    private string path = "E:\\prova.txt";
    private StreamWriter? writer;

    public GestioneCircoliPadelSuFile()
    {
        var reader = new StreamReader(path);
        var contenuto = reader.ReadToEnd();
        reader.Close();
        writer = new StreamWriter(path, false);
    }

    public bool AggiungiCircolo(CircoloPadel circolo)
    {
        try
        {
            writer?.WriteLine(circolo.Nome + " " + circolo.Id);
           // writer?.Close();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

    }

    public List<CircoloPadel> Cerca(string ricerca)
    {
        throw new NotImplementedException();
    }

    public CircoloPadel? CercaPerId(int id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        writer?.Close();
    }

    public void EliminaCircolo(int id)
    {
        throw new NotImplementedException();
    }

    public List<CircoloPadel> EstraiTuttiICircoli()
    {
        throw new NotImplementedException();
    }

    public void ModificaCircolo(CircoloPadel circolo)
    {
        throw new NotImplementedException();
    }
}


public class GestioneCircoliPadel : IGestioneCircoliPadel
{
    private List<CircoloPadel> circoli = new();


    public bool AggiungiCircolo(CircoloPadel circolo)
    {
        try
        {
            circoli.Add(circolo);
            return true;
        }
        catch 
        {
            return false;
        }
    }

    public List<CircoloPadel> Cerca(string ricerca)
    {
        return circoli.Where(circolo => 
          circolo.Nome.Contains(ricerca)  || circolo.Indirizzo!.Via.Contains(ricerca)).ToList();
        //circoli.Where(circolo => circolo.Indirizzo!.Via.Contains(ricerca));
        // circoli.Where(circolo => circolo.Giocatori.Where( g => g.Cognome == ricerca );
    }

    public CircoloPadel? CercaPerId(int id)
    {
        //foreach (var circolo in circoli)
        //{
        //    if(circolo.Id == id)
        //    {
        //        return circolo; 
        //    }
        //}
        return circoli.FirstOrDefault(c => c.Id == id);

        //return null;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void EliminaCircolo(int id)
    {
        var circolo = circoli.FirstOrDefault( x => x.Id == id);
        if(circolo != null)
        {
            circoli.Remove(circolo);
        }
    }

    public List<CircoloPadel> EstraiTuttiICircoli()
    {
        return circoli;
    }

    public void ModificaCircolo(CircoloPadel circolo)
    {
        EliminaCircolo(circolo.Id);
        AggiungiCircolo(circolo);
    }
}
