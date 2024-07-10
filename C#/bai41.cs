using System;
using System.Collections.Generic;

class bai41
{
    static void Main(string[] args)
    {
        // Tạo List of List
        List<List<string>> myList = new List<List<string>>();
        myList.Add(new List<string> { "a", "b" });
        myList.Add(new List<string> { "c", "d", "e" });
        myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
        myList.Add(new List<string> { "a", "b" });

        // Duyệt bằng for
        Console.WriteLine("Duyệt bằng for:");
        for (int i = 0; i < myList.Count; i++)
        {
            for (int j = 0; j < myList[i].Count; j++)
            {
                Console.WriteLine(myList[i][j]);
            }
        }

        Console.WriteLine("\nDuyệt bằng foreach:");
        // Duyệt bằng foreach
        foreach (List<string> subList in myList)
        {
            foreach (string item in subList)
            {
                Console.WriteLine(item);
            }
        }

        Console.ReadLine();
    }
}