using System.Text;

void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        //0x+0=0
        Console.WriteLine("vô số nghiệm");
    }
    else if (a == 0 && b != 0)
    {
        //0x+b=0
        Console.WriteLine("vô nghiệm");
    }
    else
    {
        Console.WriteLine("X = {0}", -b / a);
    }
}

void quadratic_equation_solution(double a, double b, double c)
{
    if (a == 0)
    {
        //Phuong trinh bac 1: bx + c = 0 
        first_degree_solution(b, c);
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Vo nghiem");
        }
        else if(delta == 0)
        {
            Console.WriteLine("x1 = x2 = {0}", -b / 2 * a);
        } 
        else
        {
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
        }
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phuong trinh bac 2");
Console.WriteLine("nhap he so a: ");
var a = double.Parse(Console.ReadLine());
Console.WriteLine("nhap he so b: ");
var b = double.Parse(Console.ReadLine());
Console.WriteLine("nhap he so c: ");
var c = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a, b, c);
quadratic_equation_solution(a, b, c);
