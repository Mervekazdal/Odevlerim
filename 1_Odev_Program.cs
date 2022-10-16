namespace _1_Odev
{
    internal class Program
    {
        static void Main(string[] args)


        {
            double v = 0;
            double f = 0;
            double ort = 0;
            string harfNotu = "";


            Console.WriteLine("Vize Notunuzu Giriniz.");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giriniz.");
            f = Convert.ToInt32(Console.ReadLine());
            ort = ((v * 0.4) + (f * 0.6));
            Console.WriteLine($"Ortalamanız {ort} dir");

            if (ort >= 85 && ort <= 100)
            {
                harfNotu = "AA";
                Console.WriteLine($"{harfNotu}");
            }
            else if (ort >= 75 && ort <= 84)
            {
                harfNotu = "BA";
                Console.WriteLine($"{harfNotu}");
            }
            else if (ort >= 65 && ort <= 74)
            {
                harfNotu = "BB";
                Console.WriteLine($"{harfNotu}");
            }
            else if (ort >= 50 && ort <= 64)
            { harfNotu = "CC";
                Console.WriteLine($"{harfNotu}");
            }
            else if (ort >= 25 && ort <= 49)
            {
                harfNotu = "DC";
                Console.WriteLine($"{harfNotu}");
            }
            else {
                Console.WriteLine("FF");
            }
            


        }
    }
}