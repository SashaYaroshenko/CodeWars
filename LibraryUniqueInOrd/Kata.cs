using System.Collections.Generic;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {

        // if(iterable.GetType() == typeof(string))
        if (iterable is string)
        {
            List<char> list = (iterable as string).ToList();
            List<char> result = new List<char>();


            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] != list[i + 1])
                {
                    result.Add(list[i]);
                }

            }
            return result;
        }
        return result;
    }
}