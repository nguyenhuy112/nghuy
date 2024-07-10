using System;
using System.Collections.Generic;

class bai42
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 9, 1 };

        // Sắp xếp danh sách theo thứ tự tăng dần
        numbers.Sort();

        // Đảo ngược thứ tự các phần tử trong danh sách
        numbers.Reverse();

        // Chèn số 7 vào vị trí thứ 3 (chỉ số 2)
        numbers.Insert(2, 7);

        // Xóa phần tử có giá trị 3
        numbers.Remove(3);

        // Xóa phần tử đầu tiên (giá trị 9)
        numbers.RemoveAt(0);

        // Kiểm tra xem danh sách có chứa số 9 hay không
        bool containsNine = numbers.Contains(9);

        // In các phần tử trong danh sách
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // In thông tin về việc danh sách có chứa số 9 hay không
        Console.WriteLine("Contains 9: " + containsNine);
    }
}