internal class Program
{
    private static void Main(string[] args)
    {
        //Dictionary
        // Tanımlama ve ekleme
        var telefonKodlari = new Dictionary<int, string>()
        {
            {322, "İzmir" },
            {424, "Elazığ" },
            {444, "Diyarbakır" }
        };

        //Ekleme
        telefonKodlari.Add(224, "Bursa"); // Anahtarlar unique olmalı
        telefonKodlari.Add(326, "Hatay");
        telefonKodlari.Add(212, "İstanbul(Avrupa)");

        //Ekleme
        telefonKodlari[466] = "Artvin";

        //Arama - Key
        if( !telefonKodlari.ContainsKey(312) )
        {
            Console.WriteLine("312 bulunamadı");
            telefonKodlari.Add(312, "Ankara");
            Console.WriteLine("312 anahtarlı Ankara eklendi");
        }
        Console.WriteLine();


        //Arama - Value
        if( !telefonKodlari.ContainsValue("Malatya") )
        {
            Console.WriteLine("Malatya bulunamadı");
            telefonKodlari.Add(422, "Malatya");
            Console.WriteLine("Malatya 422 anahtarıyla eklendi");
        }
        Console.WriteLine();

        //Dolaşma
        foreach (var s in telefonKodlari)
        {
            Console.WriteLine($"{s}");
        }
        Console.WriteLine();

        telefonKodlari.Remove(466);
        Console.WriteLine("466 kodlu Artvin silindi");
        Console.WriteLine();
        //Dolaşma
        foreach (var s in telefonKodlari)
        {
            Console.WriteLine($"{s}");
        }
        Console.WriteLine();


    }
}