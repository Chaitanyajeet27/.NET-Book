using c__Book;

internal class Program 
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var obj = new DerivedInterface();

        obj.method1();
        obj.method2();
    }
}