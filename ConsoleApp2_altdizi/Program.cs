using System;
using System.Collections.Generic;

namespace ConsoleApp2_altdizi
{
    class Program
    {
        public static bool AltdiziDoğrula(List<int> array, List<int> sequence)
        {

            List<int> temp = new List<int>();
            foreach (var x in sequence)
            {
                if (array.Contains(x))
                {
                    temp.Add(array.IndexOf(x));
                }
                else
                    return false;
            }

            for (int i = 0; i < temp.Count; i++)
            {
                if (i + 1 < temp.Count)
                {

                    if (temp[i] < temp[i + 1])
                    {
                        continue;
                    }
                    else
                        return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            List<int> array1 = new List<int>() { 6, 2, 5, 7, 8, 10, 45, 11, 4 };
            List<int> array2 = new List<int>() { 2, 8, 45, 11 };
            Console.WriteLine(AltdiziDoğrula(array1, array2));
            Console.ReadLine();
        }
    }
}
