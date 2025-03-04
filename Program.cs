using System;

class Program
{
    static void Main()
    {
        // İstifadəçidən iki ədəd daxil etməsini istəyirik
        Console.Write("Birinci ədədi daxil edin: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci ədədi daxil edin: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Hər iki ədədin 2-yə tam bölünüb-bölünmədiyini yoxlayırıq
        if (a % 2 == 0 && b % 2 == 0)
        {
            int cem = a + b;
            Console.WriteLine("Ədədlərin cəmi: " + cem);
        }
        else
        {
            Console.WriteLine("Daxil olunan ədədlər cüt olmalıdır!");
        }
    }
}