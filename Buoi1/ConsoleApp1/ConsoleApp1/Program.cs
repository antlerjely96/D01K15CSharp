// See https://aka.ms/new-console-template for more information

/*
    Biến (variable):
    - Được dùng để lưu giữ liệu được nhập từ bàn phím hoặc được trả về từ chương trình
    - Tính chất:
        + Biến là duy nhất
        + Mỗi biến có 1 kiểu dữ liệu
    - Quy tắc đặt tên biến:
        + Tên biến không đặt trùng nhau
        + Tên biến không trùng từ khóa
        + Tên biến không chứa ký tự đặc biệt, chỉ chứa: chữ cái (hoa, thường), số, _
        + Tên biến không bắt đầu bằng số
        + Tên biến phân biệt hoa thường
    - Khai báo biến
        + Khai báo biến và không gán giá trị
            Kiểu_dữ_liệu tên_biến;
        + Khai báo biến và gán giá trị
            Kiểu_dư_liệu tên_biến = giá_trị;
*/
int a;
int b = 10;
/*
    Hằng số (Constant):
    - Giá trị không thay đổi trong suốt quá trình chạy chương trình
    - Quy tắc đặt tên hằng số: giống quy tắc đặt tên biến
    - Khai báo hằng
        const Kiểu_dữ_liệu tên_hằng = giá_trị;
*/
const double PI = 3.14;
/*
    Kiểu dữ liệu (data type): kiểu giá trị mà biến có thể lưu trữ
    1 số kiểu dữ liệu cơ bản:
        số nguyên: int
        số thực: float, double
        ký tự: char
        chuỗi: string
        2 trạng thái: bool    
*/
/*
    Toán tử (operator): Ký hiệu cho các phép toán
    1 số loại toán tử:
        - Toán tử số học: +, -, *, /, %
        - Toán tử quan hệ: >, <, >=, <=, ==, !=
        - Toán tử logic: &&, ||, !
        - Toán tử gán: =, +=, -=, *=, /=, %=
        - Toán tử bit
        - Toán tử khác: ? :
*/
/*
    Từ khóa (keyword): những từ được xây dựng sẵn, mỗi từ có 1 chức năng riêng và không thể thay đổi
*/
/*
    Nhập xuất cơ bản
    - Xuất (hiển thị ra màn hình)
        + Hiển thị xong không xuống dòng: Console.Write()
        + Hiển thị và xuống dòng: Console.WriteLine()
    - Nhập (Nhập từ bàn phím)
        + Nhập 1 ký tự và tự động chuyển sang số nguyên (lấy trong bảng ASCII): Console.Read()
        + Nhập 1 chuỗi: Console.Readline()
*/
/*
    Cấu trúc điều khiển rẽ nhánh (Condition)
    if(điều kiện){
        khối lệnh;
    }
    
    if(điều kiện){
        khối lệnh 1;
    } else {
        khối lệnh 2;
    }
    
    if(điều kiện 1){
        khối lệnh 1;
    } else if(điều kiện 2){
        khối lệnh 2;
    } else {
        khối lệnh 3;
    }
    
    if(điều kiện 1){
        if(điều kiện 2){
            khối lệnh;
        } else if(điều kiện 3){
            khối lệnh;
        } else {
            khối lệnh;
        }
    } else if(điều kiện 4){
    } else {
    }
*/
 
/* Nhập số nguyên n từ bàn phím. Kiểm tra a là số âm hay dương */
// Khai báo
int n;
// Nhập
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
Console.WriteLine(n);
// Kiểm tra
if (n < 0)
{
    Console.WriteLine(n + " la so am");
} else if (n > 0)
{
    Console.WriteLine(n + " la so duong");
}
else
{
    Console.WriteLine(n + " la so khong am khong duong");
}