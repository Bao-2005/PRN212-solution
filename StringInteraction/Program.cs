using System.Text;

Console.OutputEncoding = Encoding.UTF8;
String ho = "Nguyễn";
String tenLot = "Thị";
String ten = "Tủn";
String full_name = ho + " " + tenLot + " " + ten;
Console.WriteLine(full_name);
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenLot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString()); //nen dung cach string builder de han che cap phat o nho qua nhieu

Console.ReadLine();