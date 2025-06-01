using System.Text;
using OOP1;

Console.OutputEncoding = Encoding .UTF8;
//Tao doi tuong duoc Category 1
Category c1 = new Category ();
c1.Id = 1;
c1.Name = "Nuoc mam";
c1.PrintInfor();
//gia su ta dio gia tri trong o nho do:
c1.Name = "Thuoc tri hoi nach";
Console.WriteLine("Sau khi doi gia tri: ");
c1.PrintInfor();
//su dung lop Employee:
Console.WriteLine("---------Employee---------");
Employee emp1 = new Employee ();
emp1.Id = 1;//goi setter property cua id
emp1.IdCard = "001";//goi setter property cua idcard
emp1.Name = "Teo";//goi setter property cua name
emp1.Email = "teo@gmail.com";//goi setter property cua email
emp1.Phone = "0987654321";//goi setter property cua phone
//xuat thong tin
emp1.PrintInfor();

Employee emp2 = new Employee()
{
    Id = 2,
    IdCard = "002",
    Name = "Ty",
    Email = "ty@gmail.com",
    Phone = "087654321"
};

Console.WriteLine("---------Employee 2---------");
emp2.PrintInfor();

Employee emp3 = new Employee();
Console.WriteLine("-----------Employee 3-----------");

emp3.PrintInfor();


Console.WriteLine("-----------Employee 4-----------");
Employee emp4 = new Employee(4, "004", "Tun", "tun@gmail.com", "01020938");
emp4.PrintInfor();
Console.WriteLine("-----------Employee 4 2-----------");
Console.WriteLine(emp4);


Console.WriteLine("========CUSTOMER 1========");
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "nguyen thi lung linh",
    Email = "lunglinh@gmail.com",
    Phone = "0987654321",
    Address = "so 2 vo nguyen giap thu duc"
};
cus1.printInfor();
cus1.Address = "dau do";
Console.WriteLine("Customer sau khi su dung");
cus1.printInfor();