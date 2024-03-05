using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearList
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();

            stringList.Add("tural");
            stringList.Add("zeynalli");

            ClearList(stringList);
            stringList.Clear();

            List<int> intList = new List<int>();

            intList.Add(19);
            intList.Add(51);

            ClearList(intList);
            intList.Clear();

            Console.WriteLine($"stringList count is {stringList.Count()} \r\nintList count is {intList.Count()}"); ;

            
        }

        public static void ClearList<T> (List<T> lists)
        {
            foreach (var list in lists)
            {
                Console.WriteLine(list);
            }

        }
    }
}
