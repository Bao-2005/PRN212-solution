using System.Text;
using Lucy_SalesDataManagement;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = @"server=ADMINISTRATOR\DOQUOCBAO;database=MyStore;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//cau 1: loc ra toan bo khach hang 
var dskh = context.Customers.ToList();
Console.WriteLine("--danh sach khach hang---");


//cau 2: tim chi tiet thong tin khach hang
//khi biet ma khach hang
int mkh = 10;
Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == mkh);
if(cust != null)
{
    Console.WriteLine("---chi tiet thong tin khach hang---");
    Console.WriteLine(cust.CustomerID + "\t" + cust.ContactName);
}

//cau 3: tu ket qua cua cau 2
//loc ra danh sach cac hoa don cua khach hang
//cac cot du lieu gom: ma hoa don + ngay hoa don
if(cust != null)
{
    var dshd = cust.Orders.Select(o => new { o.OrderID, o.OrderDate });
    var dshd2 = from o in cust.Orders
                select new { o.OrderID, o.OrderDate };
    Console.WriteLine("Danh sach hoa don cua khach hang");
    foreach(var o in dshd)
    {
        Console.WriteLine(o.OrderID + "\t" + o.OrderDate.ToString("dd/MM/yyyy"));
    }
}

//Cau 4: tu ket qua cua cau 3
//bo sung them cot tri gia cua don hang cho moi hoa don
if (cust != null)
{
    var dshd = cust.Orders.Select(o => new { o.OrderID, o.OrderDate, TotalValue = o.Order_Details
        .Sum(odd => odd.Quantity*odd.UnitPrice*(1-(decimal)odd.Discount)) });
   
    Console.WriteLine("Danh sach hoa don cua khach hang");
    foreach (var o in dshd)
    {
        Console.WriteLine(o.OrderID + "\t" + o.OrderDate.ToString("dd/MM/yyyy") + "\t" + o.TotalValue);
    }
}