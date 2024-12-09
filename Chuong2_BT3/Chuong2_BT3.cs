//CHUONG 2 BT3 : Nhập sale1, sale2 . Tính commissionRate
//Date 28/9/2024
//Name : Nguyễn Ngọc Minh Nhã
namespace Chuong2_BT3;

internal class Chuong2_BT3
{
    static void Main(string[] args)
    {
        //Declare variables
        int birthYear = 0;
        //Input
        Console.WriteLine("Vui long nhap nam sinh: ");
        int.TryParse(Console.ReadLine(), out birthYear);
        //Processing
        int currentYear = 2024;
        int age = currentYear - birthYear;
        int retirementYear = birthYear + 60;
        //Output
        Console.WriteLine($"Tuoi cua ban: {age}");
        Console.WriteLine($"Nam ve huu cua ban: {retirementYear}");
    }
}
