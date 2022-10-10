using System;
public class  MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите цифры первого числа: "); 
        int a3 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());   
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите цифры второго числа: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());

        var c3 = ((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) / 100;
        var c2 = (((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) - c3 * 100) / 10;
        var c1 = (((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) - c3 * 100) - c2 * 10;
        Console.WriteLine("Цифры числа " + ((a3 * 100) + (a2 * 10) + (b2 * 10) + a1 + b1) + ":" + c3 + ":" + c2 + ";" + c1 + ", равного сумме чисел: " + a3 + a2 + a1 + " и " + b2 + b1); ;
    }
}
