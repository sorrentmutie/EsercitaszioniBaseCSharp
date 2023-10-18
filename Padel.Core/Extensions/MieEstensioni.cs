using Padel.Core.Entities;

namespace Padel.Core.Extensions;

public static class MieEstensioni
{
    public static List<string> MioMetodoSpeciale(this List<string> lista, int n)
    {
        var result = new List<string>();
        foreach (var item in lista)
        {
            if(item.Length > n)
            {
                result.Add(item);
            }   
        }
        return result;
    }

    public static bool NomeIniziaCon(this Persona persona, string lettera)
    {
        return persona.Nome.StartsWith(lettera);
    }

}
