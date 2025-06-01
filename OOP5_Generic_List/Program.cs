/*
 * sử dụng generic list để quản lí nhân sự với đầy đủ tính năng crud
 * C-> create: tạo mới dữ liệu
 * R-> read/retrive: xem, lọc, tìm kiếm, sắp xếp, thống kê...
 * U-> update: sửa dữ liệu
 * D-> delete: xóa dữ liệu
 */

//câu 1: tạo 5 nhân viên tron gđó 3 nhân viên chính thức và 2 thời vụ
//lưu vào generic list
using System.Numerics;
using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;
List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "name 1",
    Birthday = new DateTime(1992, 11, 12)
};

FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "name 2",
    Birthday = new DateTime(1992, 11, 12)
};

FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    IdCard = "789",
    Name = "name 1",
    Birthday = new DateTime(1980, 12, 27)
};

employees.Add(fe1);
employees.Add(fe2);
employees.Add(fe3);
PartTimeEmployee pe1 = new PartTimeEmployee()
{
    Id = 4,
    IdCard = "234",
    Name = "Name 4",
    Birthday = new DateTime(1973, 12, 21),
    WorkingHour = 2
};

PartTimeEmployee pe2 = new PartTimeEmployee()
{
    Id = 5,
    IdCard = "987",
    Name = "Name 5",
    Birthday = new DateTime(1973, 12, 21),
    WorkingHour = 3
};

employees.Add(pe1);
employees.Add(pe2);

//cau 2: R-> xuat toan bo nhan su: 
Console.WriteLine("cau 2: R-> xuat toan bo nhan su:");
//cach 1: 
employees.ForEach(e =>  Console.WriteLine(e));

//cau 3: loc ra cac nhan su la chinh thuc
//cach 1:
Console.WriteLine("cau 3: loc ra cac nhan su la chinh thuc");
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
foreach (FulltimeEmployee fe in fe_list)
{
    Console.WriteLine(fe);
}

//cau 4: Tinh tong tien luong phai tra cho nhan vien chinh thuc

double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("cau 4: Tinh tong tien luong phai tra cho nhan vien chinh thuc");
Console.WriteLine(fe_sum_salary);

//cau 5: tong luong nhan vien thoi vu
double pe_sum_salary = employees.OfType<PartTimeEmployee>().
    Sum(e => e.calSalary());
Console.WriteLine(pe_sum_salary);

//cau 6: xoa thong tin nhan vien
Console.WriteLine("nhap id nhan vien muon xoa:");
int idToFind = int.Parse(Console.ReadLine());
for (int i = 0; i <= employees.Count - 1; i++)
{
    if (employees[i].Id == idToFind)
    {
        employees.Remove(employees[i]);
    }
}

employees.ForEach(e => Console.WriteLine(e));

//cau 7: sua thong tin nhan vien
Console.WriteLine("Nhap id nhan vien muon sua: ");
int id = int.Parse(Console.ReadLine());
foreach (Employee e in employees)
{
    
    if(e.Id == id)
    {
        Console.WriteLine(e);
        Console.WriteLine("nhap ten: ");
        e.Name = Console.ReadLine();
        Console.WriteLine("nhap id card: ");
        e.IdCard = Console.ReadLine();
        Console.WriteLine("nhap nam");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thang");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap ngay");
        int day = int.Parse(Console.ReadLine());
        e.Birthday = new DateTime(year, month, day);
    }
}

employees.ForEach(e => Console.WriteLine(e));