namespace deneme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float enyuksekpuan = 0;
            float endusukpuan = 100;
            string ogradi = "";
            string eniyiogr = "";
            string enkotuogr = "";
            float ort = 0;
            float vize = 0;
            float final = 0;
            float toplampuan = 0;
            float genelortlama = 0;

            Console.WriteLine("Kaç öğrencinin ortalamasını hesaplamak istiyorsunuz?");
            int ogr = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < ogr; i++)
            {

                Console.WriteLine($"Lütfen {i + 1} nolu öğrencinin adını, soyadını giriniz.");
                ogradi = Console.ReadLine();




                do


                {

                    Console.WriteLine($"Lütfen {i + 1} nolu öğrencinin vize  notunu giriniz.");
                    vize = Convert.ToSingle(Console.ReadLine());
                    if (vize < 0 || vize > 100)
                    {
                        Console.WriteLine($"Geçersiz değer girdiniz");
                    }

                }
                while (vize < 0 || vize > 100);

                do
                {


                    Console.WriteLine($"Lütfen {i + 1} nolu öğrencinin final  notunu giriniz.");
                    final = Convert.ToSingle(Console.ReadLine());
                    if (final < 0 || final > 100)
                    {
                        Console.WriteLine($"Geçersiz değer girdiniz");
                    }
                }

                while (final > 100 || final < 0);




                ort = vize * 0.4f + final * 0.6f;
                toplampuan = ort + toplampuan;

                if (ort < endusukpuan)
                {
                    endusukpuan = ort;
                    enkotuogr = ogradi;
                }
                if (ort > enyuksekpuan)
                {
                    enyuksekpuan = ort;
                    eniyiogr = ogradi;
                }
            }




            genelortlama = toplampuan / ogr;
            Console.WriteLine($"En yüksek puan alan öğrencimiz {eniyiogr} ve ortalaması {enyuksekpuan}");

            Console.WriteLine($"En düşük puan alan öğrencimiz {enkotuogr} ve ortalaması {endusukpuan}");

            Console.WriteLine($"Sınfın genel ortalaması {genelortlama}");
        }
    }
}