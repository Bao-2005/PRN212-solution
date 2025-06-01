using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }

        public Category() 
        { 
            Products = new Dictionary<int, Product>();
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
        /*
         * khi quan ly moi doi tuong ta deu phai dap ung 
         * day du tinh nang CRUD
         */

        public void addProduct(Product p)
        {
            //kiem tra neu id cua product chua ton tai thi them moi
            if(p == null)
            {
                return;//du lieu dau vao null
            }

            if(Products.ContainsKey(p.Id))
            {
                return;//id ton tai thi ko them
            }

            Products.Add(p.Id, p);//them moi product vao dictionary

        }

        //xuat toan bo san pham
        public void printAllProducts()
        {
            foreach(KeyValuePair<int, Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
        }

        //loc cac san pham co gia tu min toi max
        public Dictionary<int, Product> filterProductByPrice(double min, double max)
        {
            return Products.Where(item => item.Value.Price >= min 
                                    && item.Value.Price <= max).ToDictionary<int, Product>();
        }

        //sap xep san pham theo don gia tang dan
        public Dictionary<int, Product> sortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }
        public Dictionary<int, Product> sortComplex()
        {
            return Products.OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }
        public bool updateProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }

            if (Products.ContainsKey(p.Id) == false) 
            {
                return false;
            }

            Products[p.Id] = p;
            return true;//danh dau la sua thanh cong
        }
        public bool removeProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                return false;
            }
            Products.Remove(id);
            return true;
        }
        //viet ham cho phep xoa nhieu san pham co don gia tu a toi b

        public bool removeMultipleProduct(double min_price, double max_price)
        {
            int[] arr = new int[10];
            int j = 0;
            if(min_price == null || max_price == null)
            {
                return false;
            }
            for (int i = 1; i <= Products.Count; i++)
            {
                if(Products[i].Price >= min_price && Products[i].Price <= max_price)
                {
                    Products.Remove(Products[i].Id);
                }
            }
            return true;
        }
    }
}
