namespace _1_Odev_SwitchCase
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

            switch (ort)
            {
                case double n when n > 85 && n <= 100:
                    harfNotu = "AA";
                    Console.WriteLine("Notunuz AA'dır");
                    break;
                case double n when n > 75 && n <= 84:
                    harfNotu = "BA";
                    Console.WriteLine("Notunuz BA'dır");
                    break;
                case double n when n > 65 && n <= 74:
                    harfNotu = "BB";
                    Console.WriteLine("Notunuz BB'dir");
                    break;
                case double n when n > 50 && n <= 64:
                    harfNotu = "CC";
                    Console.WriteLine("Notunuz CC'dir");
                    break;
                case double n when n > 25 && n <= 49:
                    harfNotu = "DC";
                    Console.WriteLine("Notunuz DC'dir");
                    break;
                case double n when n < 25:
                    harfNotu = "FF";
                    Console.WriteLine("Notunuz FF'dir");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir değer girdiniz");
                    break;







            }


        }
    }
}