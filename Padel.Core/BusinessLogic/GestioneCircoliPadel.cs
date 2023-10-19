using Padel.Core.Entities;
using Padel.Core.Interfaces;
using System.Text.Json;

namespace Padel.Core.BusinessLogic;

public class GestioneCircoliPadelSuDatabase : IGestioneCircoliPadel
{
    public bool AggiungiCircolo(CircoloPadel circolo)
    {
        throw new NotImplementedException();
    }

    public List<CircoloPadel>? Cerca(string ricerca)
    {
        throw new NotImplementedException();
    }

    public CircoloPadel? CercaPerId(int id)
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
    private string path = string.Empty; 
    private readonly IMyConfiguration myConfiguration;
    private List<CircoloPadel>? circoliPadel = new();

    public GestioneCircoliPadelSuFile(IMyConfiguration myConfiguration)
    {
        this.myConfiguration = myConfiguration;
        path = myConfiguration.GetFilePath();
    }

    private void ScriviSuFile(string json, string path)
    {
        var  writer = new StreamWriter(path, false);
        writer?.WriteLine(json);
        writer?.Close();
    }

    private List<CircoloPadel>? LeggiFile(string path)
    {
        var listaLocale = new List<CircoloPadel>();

        if(!File.Exists(path))
        {
            var writer = new StreamWriter(path);
            writer.Close();            
        }

        var reader = new StreamReader(path);
        var contenuto = reader.ReadToEnd();
        if (contenuto != null && contenuto.Length > 0)
        {
            listaLocale = JsonSerializer.Deserialize<List<CircoloPadel>>(contenuto);
        }
        reader.Close();
        return listaLocale;
    }

    public bool AggiungiCircolo(CircoloPadel circolo)
    {
        try
        {
            var circoliPadel = LeggiFile(myConfiguration.GetFilePath());

            var esisteCircolo = circoliPadel?.FirstOrDefault(c => c.Id == circolo.Id);
            if(esisteCircolo == null)
            {
                circoliPadel?.Add(circolo);
                var json = JsonSerializer.Serialize(circoliPadel);
                ScriviSuFile(json, path);
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

    }

    public List<CircoloPadel>? Cerca(string ricerca)
    {
        var circoli = LeggiFile(myConfiguration.GetFilePath());
        return circoli?.Where(
            circolo => circolo.Nome.Contains(ricerca) || circolo.Indirizzo!.Via.Contains(ricerca)).ToList();
    }

    public CircoloPadel? CercaPerId(int id)
    {
        var circoli = LeggiFile(myConfiguration.GetFilePath());
        return circoli?.FirstOrDefault(c => c.Id == id);
    }

  

    public void EliminaCircolo(int id)
    {
        var circoli = LeggiFile(myConfiguration.GetFilePath());
        var circoloDaRimuovere = circoli?.FirstOrDefault(c => c.Id == id);
        if(circoloDaRimuovere != null)
        {
            circoli?.Remove(circoloDaRimuovere);
        }
        var json = JsonSerializer.Serialize(circoli);
        ScriviSuFile(json, path);
    }

    

    public List<CircoloPadel>? EstraiTuttiICircoli()
    {
        var circoli = LeggiFile(myConfiguration.GetFilePath());
        return circoli;
    }

    public void ModificaCircolo(CircoloPadel circolo)
    {
        var circoloSuFile = CercaPerId(circolo.Id);
        if(circoloSuFile != null)
        {
            EliminaCircolo(circoloSuFile.Id);
            AggiungiCircolo(circolo);
        }
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

    public List<CircoloPadel>? Cerca(string ricerca)
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
