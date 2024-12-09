namespace Chuong6_BT6;
//CHUONG 2 BT6 : Đổi ngoại tệ
//Date 05/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong2_BT6
{
    static void Main(string[] args)
    {
        double dollarUS = 0;

        Console.WriteLine("Nhap dollar: ");
        double.TryParse(Console.ReadLine(), out dollarUS);
        double pound = dollarUS * 0.8144;
        double yen = dollarUS * 105.407;
        double vnd = dollarUS * 23160;
        Console.WriteLine($"{dollarUS}$ = {pound}£");
        Console.WriteLine($"{dollarUS}$ = {yen}¥");
        Console.WriteLine($"{dollarUS}$ = {vnd}đ");
    }
}
