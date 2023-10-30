namespace Padel.Core.BusinessLogic;

public class GestoreGenerico<T> where T : new()
{
    private Queue<T> coda = new();

    public void AggiungiElementoInCoda(T elemento)
    {
        coda.Enqueue(elemento);
    }
    public void AggiungiNElementiInCoda(int n)
    {
        for (int i = 0; i < n; i++)
        {
            coda.Enqueue(new T() { });
        }
    }
    public T? EstraiElementoDallaCoda()
    {
        return coda.Dequeue();
    }
}
