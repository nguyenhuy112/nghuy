using System;
using System.Collections.Generic;

class bai38
{
    static void Main()
    {
        // Tạo một danh sách các số thực 4 byte
        List<float> numbers = new List<float>();

        // Thêm các phần tử vào danh sách
        numbers.Add(3.5f);
        numbers.Add(-1.2f);
        numbers.Add(7.8f);
        numbers.Add(-5f);

        // Hiển thị các phần tử của danh sách theo chỉ số
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Sắp xếp danh sách theo thứ tự tăng dần
        numbers.Sort();

        Console.WriteLine("Danh sách sau khi sắp xếp:");

        // Hiển thị các phần tử của danh sách sau khi sắp xếp
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}