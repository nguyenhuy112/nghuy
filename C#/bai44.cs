using System.Security.Cryptography.X509Certificates;

public class GenericClass<T>
{
    private T data ;
    public GenericClass(T value)
    { data = value; }
    public T GetData()
    { return data; }
        
    public void SetData(T value)

    { data = value; }






}
class bai44
{ static void Main()
    {
        GenericClass<int> intInstance = new GenericClass<int>(10));
        Console.WriteLine(intInstance = new GenericClass<string>("Hello, World!");
        Console.WriteLine(stringInstance.GetData());
    }

}
