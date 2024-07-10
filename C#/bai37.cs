using System;
using System.Collections.Generic;

class bai37
{
    static void Main()
    {
        // Tạo một danh sách các số nguyên
        List<int> numbers = new List<int>();

        // Thêm các phần tử vào danh sách
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        // Hiển thị số phần tử của danh sách
        Console.WriteLine($"Số phần tử của danh sách: {numbers.Count}");

        // Hiển thị các phần tử của danh sách
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}