/*
    De bai:
Nhap vao 1 so >= 0 neu nhap sai bat nhap lai
Neu nhap dung => Tinh giai thua
 */
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int n = -1;
while(n < 0)
{
    Console.WriteLine("Nhap n >= 0");
    string s = Console.ReadLine();
    if(int.TryParse(s, out n) == false)
    {
        Console.WriteLine("Ban phai nhap so nguyen");
    } 
    else
    {
        if(n < 0)
        {
            Console.WriteLine("Ban phai nhap so >= 0");
        }
    }
}

int gt = 1;
for(int i = 1; i <= n; i++)
{
    gt *= i;
}
Console.WriteLine($"{n}!={gt}");