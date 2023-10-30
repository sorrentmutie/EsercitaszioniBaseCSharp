namespace Padel.Core.Interfaces;

public class MyConfiguration : IMyConfiguration
{
    public string GetFilePath()
    {
        return "E:\\prova.txt";
    }
}
