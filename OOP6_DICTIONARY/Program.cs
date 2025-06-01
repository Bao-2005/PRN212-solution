using System.Text;
using OOP6_Dictionary;

Console.OutputEncoding = Encoding.UTF8;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc ngot";

Product product = new Product();
product.Id = 1;
product.Name = "Pepsi";
product.Quantity = 10;
product.Price = 30;
c1.addProduct(product);

Product product1 = new Product();
product1.Id = 2;
product1.Name = "Coca";
product1.Quantity = 7;
product1.Price = 25;
c1.addProduct(product1);

Product product2 = new Product();
product2.Name = "Redbull";
product2.Id = 3;
product2.Quantity = 18;
product2.Price = 30;
c1.addProduct(product2);

Product product3 = new Product();
product3.Name = "Xa xi";
product3.Id = 4;
product3.Quantity = 20;
product3.Price = 15;
c1.addProduct(product3);

Product product4 = new Product();
product4.Name = "Revive";
product4.Id = 5;
product4.Quantity = 50;
product4.Price = 12;
c1.addProduct(product4);

Console.WriteLine("Thong tin danh muc");
Console.WriteLine(c1);
Console.WriteLine("Danh sach san pham");
c1.printAllProducts();

double min_price = 10;
double max_price = 20;
Dictionary<int, Product> products_by_price = c1.filterProductByPrice(min_price, max_price);
Console.WriteLine($"danh sach cac san pham co gia tu {min_price} toi {max_price}: ");
foreach(KeyValuePair<int, Product> kvp in products_by_price)
{
    Product productItem = kvp.Value;
    Console.WriteLine(productItem);
}

Dictionary<int, Product> sorted_products = c1.sortProductByPrice();
Console.WriteLine("Danh sach cac san pham sau khi sap xep gia tang dan");
foreach(KeyValuePair<int , Product> kvp in sorted_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sorted_complex_products = c1.sortComplex();
Console.WriteLine("Danh sach cac san pham sau khi sap xep complex");
foreach (KeyValuePair<int, Product> kvp in sorted_complex_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

product4.Name = "Fanta";
product4.Price = 80;
product4.Quantity = 17;
bool ret = c1.updateProduct(product4);
Console.WriteLine("san pham sau khi chinh sua");
c1.printAllProducts();

int id = 5;
ret = c1.removeProduct(id);
if(ret == false)
{
    Console.WriteLine($"Khong tim thay ma {id} de xoa");
}
else
{
    Console.WriteLine($"Tim thay ma {id} de xoa");
    Console.WriteLine("San pham sau khi xoa la");
    c1.printAllProducts();
}

double min = 10, max = 20;
ret = c1.removeMultipleProduct(min, max);
if (ret == false)
{
    Console.WriteLine($"Khong co san pham trong muc gia");
}
else
{
    Console.WriteLine("San pham sau khi xoa theo gia la");
    c1.printAllProducts();
}

LinkedList<Category> list = new LinkedList<Category>();
list.AddLast(c1);

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia cac loai";

c2.addProduct(new Product() { Id = 6, Name = "tiger", Quantity = 10, 
Price = 300});
c2.addProduct(new Product()
{
    Id = 7,
    Name = "333",
    Quantity = 20,
    Price = 250
});
c2.addProduct(new Product()
{
    Id = 8,
    Name = "Ken",
    Quantity = 15,
    Price = 250
});
list.AddFirst(c2);
Console.WriteLine("---Danh sach toan bo san pham theo danh muc---");
foreach (Category c in list)
{
    Console.WriteLine(c);
    Console.WriteLine("--------------");
    c.printAllProducts();
    Console.WriteLine("---------------");
}