                                                                                                    using System.Collections.Generic;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        //List<T> list = new List<T>();
        //foreach (T item in iterable)
        //{
        //    if (list.LastOrDefault().Equals(item)) continue;
        //    list.Add(item);
        //    //yield return item;
        //}
        //return list;

        T itemOld = default(T);
        foreach (T item in iterable)
        {
            if (item.Equals(itemOld)) continue;
            itemOld = item;
            yield return item;
        }
    }
}