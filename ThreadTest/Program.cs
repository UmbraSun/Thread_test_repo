// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var thread = new Thread(WriteSecond);
thread.Start();
var a = 0;
while(a < 1000)
{
    Console.WriteLine("Первый");
    a++;
}
Console.ReadKey();

static void WriteSecond()
{
    int b = 0;
    while(b < 1000)
    {
        Console.WriteLine("         Второй");
        b++;
    }
}
