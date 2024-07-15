internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Hello, World!");
        Console.WriteLine("chương trình tính tổng 2 số");
        int so1, so2, tong, hieu, tich;
        Console.WriteLine(" Nhập số 1: ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Nhập số 2: ");
        so2 = Convert.ToInt32(Console.ReadLine());
        tong = so1 + so2;
        hieu = so1 - so2;
        tich = so1 * so2;
        Console.WriteLine(" Tổng của hai số " + so1 + " và " + so2 + " là " + tong);
        Console.WriteLine($"Tổng của hai số {so1} và {so2} là {tong} ");
        Console.WriteLine("Tổng của hai số {0} và {1} là {2}", so1, so2, tong);
        Console.WriteLine($" Hiệu của hai số {0} và {1} và {2} ", so1, so2, hieu);
        Console.WriteLine(" Tích của hai số " + so1 + " và " + so2 + " là " + tich);
        double thuong;
        try
        {
            thuong = so1 / so2;
            Console.WriteLine($"Thương của hai số {so1} và {so2} là {thuong}");

        }
        catch
        {
            Console.WriteLine("Không thể chia được cho 0");
        }
    }
}