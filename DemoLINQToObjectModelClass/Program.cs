using System.Text;
using DemoLINQToObjectModelClass;

Console.OutputEncoding = Encoding.UTF8;
ListProduct lp = new ListProduct();
lp.gen_products();

//Cau 1: loc ra cac san pham co gia tu a toi b
List<Product> listProduct = lp.FilterProductsByPrice2(100, 200);
listProduct.ForEach(p => Console.WriteLine(p));

//Cau 2: Sap xep san pham theo don gia tang dan
var result2 = lp.SortProductByPriceAsc2();
Console.WriteLine("cac san pham sau khi sap xep gia tang dan");
result2.ForEach(p => Console.WriteLine(p));

//Cau 3: Sap xep san pham theo don gia giam dan
var result3 = lp.SortProductByPriceDesc();
Console.WriteLine("cac san pham sau khi sap xep gia giam dan");
result3.ForEach(p => Console.WriteLine(p));

//Cau 4: tinh tong gia tri cac san pham trong kho hang
Console.WriteLine("Tong gia tri trong khi hang = " + lp.SumOfValue());

//Cau 5: Tim chi tiet san pham khi biet ma san pham
Product p = lp.SearchProductDetail(3);
if (p != null)
{
    Console.WriteLine("Tim thay san pham, thong tin cho tiet: ");
    Console.WriteLine(p);
}
else
{
    Console.WriteLine("khong tim thay");
}

//Cau 6: Viet ham loc ra top n san pham co tri gia lon nhat
Console.WriteLine("Top san pham gia tri cao nhat la");
var result5 = lp.TopHighestPrice(5);
result5.ForEach(p => Console.WriteLine(p));