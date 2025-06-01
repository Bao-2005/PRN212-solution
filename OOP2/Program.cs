using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee obama = new FulltimeEmployee();
obama.Id = 1;
obama.IdCard = "124";
obama.Name = "Barac Obama";
obama.Birthday = new DateTime(1960, 12, 25);
Console.WriteLine("Thông tin của Obama: ");
Console.WriteLine("Id  = " + obama.Id);
Console.WriteLine("Id card = " + obama.IdCard);
Console.WriteLine("Name = " + obama.Name);
Console.WriteLine("Birthday = " + obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của obama: " + obama.calSalary());
PartTimeEmployee trump = new PartTimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Donald Trump",
    Birthday = new DateTime(1954, 1, 15),
    WorkingHour = 2
};
Console.WriteLine("Thông tin của Trump: ");
Console.WriteLine("Id  = " + trump.Id);
Console.WriteLine("Id card = " + trump.IdCard);
Console.WriteLine("Name = " + trump.Name);
Console.WriteLine("Birthday = " + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của trump: " + trump.calSalary());

Console.WriteLine("-----------Thông tin cách 2-----------");
Console.WriteLine(obama);
Console.WriteLine(trump);