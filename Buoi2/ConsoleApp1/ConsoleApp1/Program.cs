// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

/*
    Mảng (array): là 1 tập hợp các phần tử có cùng kiểu dữ liệu
    Các phần tử trong mảng được phân biệt với nhau bằng 1 số nguyên được gọi là index
    Index bắt đầu từ 0 đến n - 1 với n là số phần tử
    Khai bao mang:
        kieu_du_lieu[] ten_mang = new kieu_du_lieu[so_phan_tu];
    Truy xuất phần tử trong mảng
        ten_mang[index];
    Để truy xuất lần lượt từng phần tử trong mảng
        Dùng vòng lặp chạy theo index: vòng lặp bắt đầu từ 0 đến n - 1
*/

/*
    1. Nhap mang so nguyen co n phan tu. Tinh tong cac phan tu
*/

//Khai bao n, tong
int n, tong = 0;
//Nhap n
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Khai bao mang
int[] arr = new int[n];
//Nhap mang
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Tinh tong cac phan tu
for (int i = 0; i < n; i++)
{
    tong += arr[i];
}
//In ket qua
Console.WriteLine("Tong cac phan tu trong mang: " + tong);

/*
    2. Nhap mang so thuc co n phan tu. Tim max, min
    3. Nhap mang so thuc co m phan tu. Sap xep mang theo thu tu tang dan
    4. Nhap mang so nguyen co n phan tu. Hien thi cac phan tu co gia tri la so nguyen to
*/