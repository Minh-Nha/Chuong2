namespace Chuong2_BT7;
//CHUONG 2 BT4 : Nhập ký tự chuyển ra mã ascii
//Date 05/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong2_BT7
{
    static void Main(string[] args)
    {
        char character;
        Console.Write("Nhap 1 ky tu: ");
        char.TryParse(Console.ReadLine(), out character);
        Console.WriteLine();
        Console.WriteLine($"Ma ascii cua '{character}' la {(int)character}");
        Console.WriteLine($"Ky tu ke tiep cua '{character}' la {(char)(character+1)}");
    }
}
