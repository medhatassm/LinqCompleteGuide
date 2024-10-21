using System;

namespace Pajination;

public static class ExtentionMethod
{
    public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source,
             int page = 1, int size = 10) where T : class
    {
        if (page <= 0)
        {
            page = 1;
        }

        if (size <= 0)
        {
            size = 10;
        }

        var total = source.Count();

        var pages = (int)Math.Ceiling((decimal)total / size);

        var result = source.Skip((page - 1) * size).Take(size);

        return result;
    }
}
