using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
       // string test = "../input/day_1_part_1_example.txt";
        string real = "../input/day_1_part_1.txt";
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        foreach (string item in ReadFile(real))
        {
            string[] temp = item.Split("   ");

            list1.Add(Convert.ToInt32(temp[0]));
            list2.Add(Convert.ToInt32(temp[1]));
        }
        list1.Sort();
        list2.Sort();
        int sum = 0;
        for (int i = 0; i < list1.Count; i++)
        {
            sum += Math.Abs(list1[i] - list2[i]);
        }

        /////// PART 2 ////////

        int similarityScore = list1.Sum(num => num * list2.Count(x => x == num));

        Console.WriteLine(similarityScore);

        /////// PART 2 ////////

        Console.WriteLine(sum);
        Console.ReadKey();
    }

    static string[] ReadFile(string Path)
    {
        string[] lines = File.ReadAllLines(Path);
        return lines;
    }

}

//EventInfoExtensions text datei = 2 listen -> liste 1 & liste 2