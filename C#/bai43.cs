using System;

public class bai43
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int a = 5, b = 7;
        double c = 3.4, d = 2.5;

        Console.WriteLine("Before swap:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);

        Swap<int>(ref a, ref b);
        Swap<double>(ref c, ref d);

        Console.WriteLine("After swap:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
    }
}
//Khi không sử dụng ref, tham số của phương thức Swap<T>() sẽ được truyền vào bằng cách sao chép giá trị, thay vì truyền vào bằng tham chiếu. Điều này có nghĩa là các thay đổi được thực hiện trong phương thức Swap<T>() sẽ chỉ ảnh响đến các biến cục bộ bên trong phương thức, chứ không ảnh hưởng đến các biến a, b, c, d ở bên ngoài.