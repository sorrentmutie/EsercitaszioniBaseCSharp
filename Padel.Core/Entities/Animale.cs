namespace Padel.Core.Entities;

public abstract class Animale
{
    public abstract string SuonoEmesso();
  
}


public class Gatto: Animale
{
    public override string SuonoEmesso()
    {
        return "Miao";
    }
}

public sealed class Cane: Animale
{
    public override string SuonoEmesso()
    {
        return "Bau";
    }
}

//public class Doberman : Cane
//{

//}
