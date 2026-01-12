// Вариант 3: поиск пересечения двух массивов

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    // Старый (неэффективный) алгоритм O(n^3)
    static List<int> FindIntersectionNaive(int[] arr1, int[] arr2)
    {
        List<int> intersection = new List<int>();

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j] && !intersection.Contains(arr1[i]))
                {
                    intersection.Add(arr1[i]);
                }
            }
        }

        return intersection;
    }

    // Новый алгоритм на HashSet: O(n)
    static List<int> FindIntersectionOptimized(int[] arr1, int[] arr2)
    {
        HashSet<int> set2 = new HashSet<int>(arr2);
        HashSet<int> resultSet = new HashSet<int>();

        foreach (int x in arr1)
        {
            if (set2.Contains(x))
            {
                resultSet.Add(x);
            }
        }

        return resultSet.ToList();
    }

    // Вспомогательный метод для генерации случайного массива
    static int[] GenerateArray(int n, int maxValue = 100000)
    {
        Random rnd = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = rnd.Next(maxValue);
        return arr;
    }

    // Замер времени выполнения одного вызова
    static long Measure(Func<int[], int[], List<int>> func, int[] arr1, int[] arr2)
    {
        Stopwatch sw = Stopwatch.StartNew();
        var result = func(arr1, arr2);
        sw.Stop();
        return sw.ElapsedTicks;
    }

    static void Main()
    {
        // Проверка корректности на маленьком примере
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 3, 4, 5, 6, 7 };

        var naive = FindIntersectionNaive(arr1, arr2);
        var opt = FindIntersectionOptimized(arr1, arr2);

        Console.WriteLine("Наивное пересечение: " + string.Join(", ", naive));
        Console.WriteLine("Оптимизированное пересечение: " + string.Join(", ", opt));
        Console.WriteLine();

        // Сравнение производительности
        int[] sizes = { 100, 1000, 5000, 10000 };

        Console.WriteLine("N\tNaive (ticks)\tOptimized (ticks)");

        foreach (int n in sizes)
        {
            int[] a = GenerateArray(n);
            int[] b = GenerateArray(n);

            long tNaive = Measure(FindIntersectionNaive, a, b);
            long tOpt = Measure(FindIntersectionOptimized, a, b);

            Console.WriteLine($"{n}\t{tNaive}\t\t{tOpt}");
        }
    }
}
