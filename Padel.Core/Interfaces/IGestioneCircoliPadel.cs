using Padel.Core.Entities;
namespace Padel.Core.Interfaces;

public interface IGestioneCircoliPadel
{
    List<CircoloPadel>? EstraiTuttiICircoli();
    List<CircoloPadel>? Cerca(string ricerca);
    CircoloPadel? CercaPerId(int id);
    bool AggiungiCircolo(CircoloPadel circolo);
    void EliminaCircolo(int id);    
    void ModificaCircolo(CircoloPadel circolo);
}

public interface IGestioneGenerica<T>
{
    List<T> EstraiTutti();
    List<T> Cerca(string ricerca);
    T? CercaPerId(int id);
    bool Aggiungi(T item);
    void Elimina(int id);
    void Modifica(T item);
}