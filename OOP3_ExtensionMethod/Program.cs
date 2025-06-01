using System.Text;
using OOP3_ExtensionMethod;

Console.OutputEncoding = Encoding.UTF8;
int n1 = 5;
int n2 = 10;
Console.WriteLine($"Tong tu 1 toi {n1} = {n1.tongTu1ToiN()}");
Console.WriteLine($"Tong tu 1 toi {n2} = {n2.tongTu1ToiN()}");
Console.WriteLine($"Tong tu 1 toi 8 = {8.tongTu1ToiN()}");
Console.WriteLine("8 + 7 = " + 8.cong(7));

int[] m = new int[8];
m.taoMang();
Console.WriteLine("Mang sau khi tao ngau nhien: ");
m.xuatMang();
Console.WriteLine("mang sau khi sap xep tang dan");
m.sapXepMangTangDan();
m.xuatMang();
Console.WriteLine("mang sau khi sap xep giam dan");
m.sapXepMangGiamDan();
m.xuatMang();