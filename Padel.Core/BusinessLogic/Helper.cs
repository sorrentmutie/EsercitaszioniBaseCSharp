namespace Padel.Core.BusinessLogic;

public class Helper<T> where T: IComparable
{
    public T MyMax(T o1, T o2)
    {
       if(o1.CompareTo(o2) <= 0)
        {
            return o2;
        } else
        {
            return o1;
        }
    }
}
