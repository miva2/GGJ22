using System.Collections.Generic;
using System;

public static class ListExtensions
{
    private static Random rng = new Random();

    public static T GetRandomElement<T>(this IList<T> list)
    {
        return list[rng.Next(list.Count)];
    }

}
