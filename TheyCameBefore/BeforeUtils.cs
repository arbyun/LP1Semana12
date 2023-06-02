using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item)
            where T : struct, IComparable<T>
        {
            List<T> result = new List<T>();

            foreach (var currentItem in items)
            {
                if (currentItem.CompareTo(item) < 0)
                {
                    result.Add(currentItem);
                }
            }

            return result;
        }
    }
}