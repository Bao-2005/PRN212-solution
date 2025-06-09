using System;
using System.Text;
using DemoAliasClone;

Console.OutputEncoding = Encoding.UTF8;

Customer c1 = new Customer();
c1.Id = 1;
c1.Name = "tran thi teo";

Customer c2 = new Customer();
c2.Id = 2;
c2.Name = "nguyen van tet";

c1 = c2;
//la c1 tro toi vung nho ma c2 dang quan ly
//chu khong phai c1 = c2
//luc nay xay ra 2 tinh huong
//tinh huong 1: o nho alpha ma c1 quan ly luc nay bi trong
//khong con doi tuong nao tham gia quan ly nua
//=> he dieu hanh se thu hoi o nho alpha nay
//goi la co che gom rac tu dong: automatic garbage collection
//ta khong the nao lay duoc gia tri tai o nho nay nua

//tinh huong 2: luc nay o nho beta se co 2 doi tuong tham gia quan ly
//- doi tuong ban dau la c2
//- bay gio co them doi tuong c1 quan ly
//truong hop 1 o nho tu 2 doi tuong tro len tham gia quan ly
//no duoc goi la alias
//-> bat ky 1 doi tuong nao doi gia tri tai o nho beta
//-> thi cac doi tuong con lai deu bi anh huong

c1.Name = "HO DO";
//thi luc nay c2 cung bi doi ten thanh ho dovi c1 va c2 dang quan ly 1 o nho
Console.WriteLine("Ten cua c2 = " + c2.Name);

Customer c3 = new Customer();
Customer c4 = c3;
c3 = c1;
//khong co thu hoi o nho c3 dang quan ly o dong 36
Product p1 = new Product()
{
    ID = 1,
    Name = "p1",
    Quantity = 10,
    Price = 20
};

Product p2 = new Product()
{
    ID = 2,
    Name = "p2",
    Quantity = 15,
    Price = 22
};

p1 = p2;
Console.WriteLine("---Thong tin cua p1---");
Console.WriteLine(p1);
Console.WriteLine("---Thong tin cua p2---");
Console.WriteLine(p2);

p2.Name = "Thuoc tri hoi nach";
p2.Quantity = 50;
p2.Price = 100;
Console.WriteLine("---Thong tin cua p1 khi p2 doi---");
Console.WriteLine(p1);

Product p3 = new Product()
{
    ID = 3,
    Name = "p3",
    Quantity = 15,
    Price = 22
};
Product p4 = new Product()
{
    ID = 4,
    Name = "p4",
    Quantity = 15,
    Price = 22
};
Product p5 = p3;
p3 = p4;

//He dieu hanh co thu hoi o nho da cap phat cho p3 quan ly truoc do khong
//vi sao
//Neu bo sung:
p5 = p3;
//thi co thu hoi o nho da cap phat cho p3 hay ko? vi sao?
Product p6 = p4.Clone();//he dieu hanh se sao chep toan bo du lieu trong o nho ma p4 dang quan ly qua 1 o nho moi
//va giao cho p6 quan ly o nho moi nay
//p4 va p6 quan ly 2 o nho khac nhau hoan toan nhung co gia tri giong nhau
//==>p6 doi ko lien can p4 va nguoc lai
Console.WriteLine("Thong tin cua p4");
Console.WriteLine(p4);
Console.WriteLine("Thong tin cua p6");
Console.WriteLine(p6);
p4.Name = "Thuoc tri xam";
Console.WriteLine("Thong tin cua p4");
Console.WriteLine(p4);
Console.WriteLine("Thong tin cua p6");
Console.WriteLine(p6);