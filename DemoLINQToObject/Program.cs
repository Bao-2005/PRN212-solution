using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] arr = { 100, 50, 120, 130, 80, 70, 123, 17, 237 };
/*
 * Cau 1: Dung LINQ to Object de loc ra cac so chan:
 */
//Cach Method Syntax
var result = arr.Where(x => x % 2  == 0);
//Cach Query Syntax
var result2 = from x in arr
              where x % 2 == 0
              select x;
Console.WriteLine("Danh sach cac so chan");
result2.ToList().ForEach(x => Console.WriteLine(x));
/*Cau 2: sap xep danh sach tang dan
 */
var result3 = arr.OrderBy(x => x);
var result4 = from x in arr
              orderby x
              select x;
Console.WriteLine("Danh sach sau sap xep");
foreach (var item in result4)
{
    Console.WriteLine(item + "\t");
}
/*
cau 3 : sap xep theo giam dan
*/
var result5 =  arr.OrderByDescending(x => x);
var result6 = from x in arr
              orderby x descending
              select x;

//Cau 4: dem so luong cac so le
int dem = arr.Where((x) => x % 2 != 0).Count();

