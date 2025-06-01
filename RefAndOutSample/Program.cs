using System.Text;

Console.OutputEncoding = Encoding.UTF8;
void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");
}

int n = 5;
Console.WriteLine($"n trc khi vao ham = {n}");
ham1(n);
Console.WriteLine($"n sau khi vao ham = {n}");

void ham2(ref int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");
}

Console.WriteLine("-------------------");
n = 5;
Console.WriteLine($"n trc khi vao ham = {n}");
//int m;
//ham2(ref m); se bao loi vi dong 24 m ko co gia tri
ham2(ref n);
Console.WriteLine($"n sau khi vao ham = {n}");

void ham3(out int n)
{
    n = 9;
    Console.WriteLine($"n trong ham = {n}");
}

Console.WriteLine("-------------------");
n = 113;

Console.WriteLine($"n trc khi vao ham = {n}");
ham3(out n);
Console.WriteLine($"n sau khi vao ham = {n}");
