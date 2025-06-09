using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQToObjectModelClass
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_products()
        {
            products.Add(new Product() { ID = 1, Name = "p1", Quantity = 10, Price = 700 });
            products.Add(new Product() { ID = 2, Name = "p2", Quantity = 20, Price = 200 });
            products.Add(new Product() { ID = 3, Name = "p3", Quantity = 30, Price = 600 });
            products.Add(new Product() { ID = 4, Name = "p4", Quantity = 15, Price = 400 });
            products.Add(new Product() { ID = 5, Name = "p5", Quantity = 7, Price = 800 });
            products.Add(new Product() { ID = 6, Name = "p6", Quantity = 4, Price = 300 });
            products.Add(new Product() { ID = 7, Name = "p7", Quantity = 50, Price = 100 });
            products.Add(new Product() { ID = 8, Name = "p8", Quantity = 8, Price = 500 });
            products.Add(new Product() { ID = 9, Name = "p9", Quantity = 27, Price = 150 });
            products.Add(new Product() { ID = 10, Name = "p10", Quantity = 13, Price = 900 });
        }
        public List<Product> FilterProductsByPrice(double price1, double price2)
        {
            var result = from p in products
                         where p.Price >= price1 && p.Price <= price2
                         select p;
            return result.ToList();
        }
        public List<Product> FilterProductsByPrice2(double price1, double price2)
        {
            var result = products
                .Where(p => p.Price >= price1 && p.Price <= price2)
                .ToList();
            return result;
        }
        public List<Product> SortProductByPriceAsc()
        {
            return products
                .OrderBy(p => p.Price)
                .ToList();
        }
        public List<Product> SortProductByPriceAsc2()
        {
            var result = from p in products
                         orderby p.Price
                         select p;
            return result.ToList();
        }
        public List<Product> SortProductByPriceDesc2()
        {
            var result = from p in products
                         orderby p.Price descending
                         select p;
            return result.ToList();
        }
        public List<Product> SortProductByPriceDesc()
        {
            return products
                .OrderByDescending(p => p.Price)
                .ToList();
        }
        public double SumOfValue()
        {
            return products.Sum(p => p.Price * p.Quantity);
        }
        public Product SearchProductDetail(int id)
        {
            return products.FirstOrDefault(p => p.ID == id);//ham nay tra ve doi tuong neu tim thay
            //ko thi tra ve null
        }
        public List<Product> TopHighestPrice(int n)
        {
            //List<Product> tmp = new List<Product>();
            //int count = 1;
            //var result = products
            //    .OrderByDescending(p => p.Price);
            //foreach (var p in result)
            //{
            //    if (count <= n)
            //    {
            //        tmp.Add(p);
            //        count++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //return tmp.ToList();
            return products.OrderByDescending(p => p.Price * p.Quantity).Take(n).ToList();
        }
    }
}
