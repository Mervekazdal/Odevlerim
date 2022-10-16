namespace _1_Odev_SwichCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = 0;
            string mevsim = "";
            string ay = "";
            Console.WriteLine("Lütfen ay giriniz");
            ay = Console.ReadLine();
            
            switch (ay)
            {
                case "Ocak":
                    month = 1;
                    mevsim = "Kış";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Subat":
                    month = 2;
                    mevsim = "Kış";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Mart":
                    month = 3;
                    mevsim = "İlk Bahar";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Nisan":
                    month = 4;
                    mevsim = "İlk Bahar";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Mayıs":
                    month = 5;
                    mevsim = "İlk Bahar";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Haziran":
                    month = 6;
                    mevsim = "Yaz";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Temmuz":
                    month = 7;
                    mevsim = "İlk Bahar";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Ağustos":
                    month = 8;
                    mevsim = "Yaz";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Eylül":
                    month = 9;
                    mevsim = "Son Bahar";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Ekim":
                    month = 10;
                    mevsim = "Son Bahar";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Kasım":
                    month = 11;
                    mevsim = "Son Bahar";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
                break;

                case "Aralık":
                    month = 12;
                    mevsim = "Kış";
                    Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");                
                break;

                default:
                Console.WriteLine("Geçersiz bir değer girdiniz");
                break;



            }

            
       
        }
    }
}