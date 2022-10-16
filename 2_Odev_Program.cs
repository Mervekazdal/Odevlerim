namespace _2_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = 0;
            string mevsim = "";

            Console.WriteLine("Lütfen ay giriniz");
            string ay = Console.ReadLine();
            


            if (ay == "Ocak") {

                month = 1;
                mevsim = "Kış";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }


            else if (ay == "Şubat") {

                month = 2;
                mevsim = "Kış";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }

            else if (ay == "Mart") {

                month = 3;
                mevsim = "İlk Bahar";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }


            else if (ay == "Nisan") {

                month = 4;
                mevsim = "İlk Bahar";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");

            }

            else if (ay == "Mayıs") {

                month = 5;
                mevsim = "İlk Bahar";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }



            else if (ay == "Haziran") {

                month = 6;
                mevsim = "Yaz";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }



            else if (ay == "Temmuz") {

                month = 7;
                mevsim = "Yaz";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }



            else if (ay == "Ağustos") {

                month = 8;
                mevsim = "Yaz";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }



            else if (ay == "Eylül") {

                month = 9;
                mevsim = "Son Bahar";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }



            else if (ay == "Ekim") {

                month = 10;
                mevsim = "Son Bahar";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }




            else if (ay == "Kasım") {

                month = 11;
                mevsim = "Son Bahar";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");

            }



            else if (ay == "Aralık")
            {

                month = 12;
                mevsim = "Kış";

                Console.WriteLine($"Senenin {month} ayındayız ve {mevsim} mevsimindeyiz");
            }



            else {

                Console.WriteLine("Geçersiz bir değer girdiniz");
            }
            

            }
    }
}