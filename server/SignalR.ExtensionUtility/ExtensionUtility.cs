using System;
using System.Collections.Generic;

namespace SignalR.ExtensionUtility
{
    public static class ExtensionUtility
    {
        public static void map<T>(this IEnumerable<T> enumerable, Action<T, int> handler)
        {
            int idx = 0;
            foreach (T item in enumerable)
                handler(item, idx++);
        }
    }
}
