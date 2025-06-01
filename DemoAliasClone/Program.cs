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