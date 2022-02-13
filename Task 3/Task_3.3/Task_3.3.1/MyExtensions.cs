using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_3._3._1
{
    public static class MyExtensions
    {
        public static T Sum<T>(this IEnumerable<T> array)
        {
            T sum = default(T);
            foreach (var item in array)
                sum += (dynamic)item;

            return sum;
        }

        public static T Average<T>(this IEnumerable<T> array) => (dynamic)array.Sum() / array.Count();

        public static T MostFrequent<T>(this IEnumerable<T> array)
        {
            Dictionary<T, int> mostFreq = new();
            foreach (var item in array)
            {
                if (mostFreq.ContainsKey(item))
                    mostFreq[item]++;

                else
                    mostFreq.Add(item, 1);
            }
            return mostFreq.OrderByDescending(d => d.Value).First().Key;
        }
    }
}
