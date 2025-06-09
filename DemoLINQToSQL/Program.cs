using System.Text;
using DemoLINQToSQL;

Console.OutputEncoding = Encoding.UTF8;
//khai bao chuoi ket noi toi co so du lieu
string connectionString = @"server=ADMINISTRATOR\DOQUOCBAO;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Cau 1: truy van toan bo danh muc
var dsdm = context.Categories.ToList();
Console.WriteLine("---Danh sach danh muc---");
foreach (var category in dsdm)
{
    Console.WriteLine(category.CategoryID + "\t" + category.CategoryName);
}
//cau 2 lay thong tin chi tiết danh mục khi biết mã
int madm = 7;
Category cat = context.Categories.FirstOrDefault(c => c.CategoryID == madm);
if(cat == null)
{
    Console.WriteLine("Không tìm thấy dnah mục có mã = " + madm);
} else
{
    Console.WriteLine("---Tìm thấy danh mục có mã = " + madm + "---");
    Console.WriteLine(cat.CategoryID + "\t" + cat.CategoryName);
}

//Câu 3 dùng query syntax để truy vấn toàn bộ sản phẩm 
var dssp = from p in context.Products
           select p;
Console.WriteLine("---Danh sách sản phẩm:---");
foreach (var product in dssp)
{
    Console.WriteLine(product.ProductID + "\t" + product.ProductName + "\t" + product.UnitPrice);
}
//câu 4: dùng query syntax và anonymous type để lọc ra 
//các sản phẩm nhưng chỉ lấy mã sản phẩm và đơn giá đồng thời sắp xếp giảm dần
var dssp4 = from p in context.Products
            orderby p.UnitPrice descending
            select new {p.ProductID, p.UnitPrice};
Console.WriteLine("Danh sach cac san pham theo yeu cau 4");
foreach(var product in dssp4)
{
    Console.WriteLine(product.ProductID + "\t" + product.UnitPrice);
}

//Cau 5: sua cau 4 theo extention method (method syntax)
var dssp5 = context.Products.OrderByDescending(p =>  p.UnitPrice).Select(p => new { p.ProductID, p.UnitPrice });
Console.WriteLine("Danh sach cac san pham theo yeu cau 5");
foreach (var product in dssp5)
{
    Console.WriteLine(product.ProductID + "\t" + product.UnitPrice);
}

//câu 6: lọc ra top 3 sản phẩm có giá lớn nhất hệ thống
var dssp6 = context.Products.OrderByDescending(p => p.UnitPrice).Take(3);
Console.WriteLine("Danh sach cac san pham theo yeu cau 6");
foreach (var product in dssp6)
{
    Console.WriteLine(product.ProductID + "\t" + product.UnitPrice + "\t" + product.ProductName);
}

//câu 7: sửa tên danh mục khi biết mã
int madm_edit = 7;
Category cat_edit = context.Categories.FirstOrDefault(c => c.CategoryID == madm_edit);
if(cat_edit != null)
{
    cat_edit.CategoryName = "Hàng trôi nổi";
    context.SubmitChanges();//xac nhan luu thay doi
}

////Câu 8: xóa danh mục khi biết mã
//int madm_xoa = 7;
//Category cat_remove = context.Categories.FirstOrDefault(c => c.CategoryID == madm_xoa);
//if(cat_remove != null)
//{
//    context.Categories.DeleteOnSubmit(cat_remove);
//    context.SubmitChanges();
//}
//Câu 9: xóa cac danh mục nếu không có bất sản phẩm nào
var dsdm_empty_product = context.Categories.Where(c => c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dsdm_empty_product);
context.SubmitChanges();

//Câu 10: thêm mới 1 danh mục
Category c_new = new Category();
c_new.CategoryName = "Hang lau tu trung quoc";
context.Categories.InsertOnSubmit(c_new);
context.SubmitChanges();

//Cau 11: Them moi nhieu danh muc
List<Category> lists = new List<Category>();
lists.Add(new Category() { CategoryName = "Hang Gia Dung" });
lists.Add(new Category() { CategoryName = "Hang Dien tu" });
lists.Add(new Category() { CategoryName = "Hang Phu Kien" });
context.Categories.InsertAllOnSubmit(lists);
context.SubmitChanges();