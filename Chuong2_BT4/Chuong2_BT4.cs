using System;
//CHUONG 2 BT4 : Hoán vị 2 giá trị
//Date 05/10/2024
//Name : Nguyễn Ngọc Minh Nhã
namespace Chuong2_BT4;

internal class Chuong2_BT4
{
    static void Main(string[] args)
    {   
        //Declare variables
        int num1, num2 = 0;
        //Input
        Console.WriteLine("Vui long nhap num1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Vui long nhap num2: ");
        int.TryParse(Console.ReadLine(), out num2);
        //Processing
        int temp = num1;
        num1 = num2;
        num2 = temp;
        //Output 
        Console.WriteLine($"Num1 co gia tri la: {num1}");
        Console.WriteLine($"Num2 co gia tri la: {num2}");
    }
}
