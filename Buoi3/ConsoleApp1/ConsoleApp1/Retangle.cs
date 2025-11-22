namespace ConsoleApp1;

public class Retangle : Shape
{
    public double chieuDai;
    public double chieuRong;

    public void tinhChuVi()
    {
        Console.WriteLine("Chu vi: " + ((this.chieuDai + this.chieuRong) * 2));
    }

    public void tinhDienTich()
    {
        Console.WriteLine("Dien tich: " + (this.chieuDai * this.chieuRong));
    }
}