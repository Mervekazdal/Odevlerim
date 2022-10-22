namespace Odev_4
{
    internal class Program
    {
        int denemesayisi, loginbasaridurumu = 0;
        string input1, kullaniciadi, sifre = "";
        static void Main(string[] args)
        {
            int denemesayisi = 0;
            int loginbasaridurumu = 0;
            string input1, kullaniciadi, sifre = "";

            Console.WriteLine("Lütfen kullanıcı adınızı belirleyiniz.");
            kullaniciadi =  Console.ReadLine();

            Console.WriteLine("Lütfen şirenizi belirleyiniz.");
            sifre = Console.ReadLine();    
            
            for ( int i = 0; i < 3; i ++ )
            {
                Console.WriteLine("Lütfen şifrenizi giriniz.");
                input1 = Console.ReadLine();

                if (input1 != sifre)
                {
                    Console.WriteLine("Hatalı şifre girdiniz.");
                    denemesayisi++;

                }
                else
                {
                    Console.WriteLine("Giriş başarılı bir şekilde tamamlandı.");
                    break;
                }

                if ( denemesayisi == 3 )
                {
                    Console.WriteLine("Üzgünüm hakkınız bitti");
                    break;
                }
            }   


        }
    }
}