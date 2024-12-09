namespace Chuong2_BT5;
//CHUONG 2 BT5 : Bảng cửu chương
//Date 05/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong2_BT5
{
    static void Main(string[] args)
    {
        int n = 0;
        Console.WriteLine("Nhap n: ");
        int.TryParse(Console.ReadLine(), out n);
        //Console.WriteLine($"{n} x 1 = {n * 1}");
        //Console.WriteLine($"{n} x 2 = {n * 2}");
        //Console.WriteLine($"{n} x 3 = {n * 3}");
        //Console.WriteLine($"{n} x 4 = {n * 4}");
        //Console.WriteLine($"{n} x 5 = {n * 5}");
        //Console.WriteLine($"{n} x 6 = {n * 6}");
        //Console.WriteLine($"{n} x 7 = {n * 7}");
        //Console.WriteLine($"{n} x 8 = {n * 8}");
        //Console.WriteLine($"{n} x 9 = {n * 9}");
        //Console.WriteLine($"{n} x 10 = {n * 10}");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
