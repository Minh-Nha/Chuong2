//CHUONG 2 BT2 : Nhập sale1, sale2 . Tính commissionRate
//Date 28/9/2024
//Name : Nguyễn Ngọc Minh Nhã
namespace Chuong2_BT1;

internal class Chuong2_BT2
{
    static void Main(string[] args)
    {
        //declare variables
        long sale1 = 0;// giá món 1
        long sale2 = 0;// giá món 2
        float commissionRate = 0; // tỷ lệ hoa hồng

        //Input 
        Console.WriteLine("Nhap sale1: ");
        long.TryParse(Console.ReadLine(), out sale1);
        Console.WriteLine("Nhap sale2: ");
        long.TryParse(Console.ReadLine(), out sale2);
        Console.WriteLine("Nhap commission rate: ");
        float.TryParse(Console.ReadLine(), out commissionRate);

        //Processing
        var totalSale = sale1 + sale2;
        var commission = totalSale * commissionRate;

        //Output
        Console.WriteLine("Tong tien: " + totalSale);
        Console.WriteLine($"Commission: {commission}");
    }
}
