using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("99999-0000", "Nokia Tijolão", "1111111111", 16);
        Smartphone iphone = new Iphone("88888-0000", "iPhone 15 Pro", "2222222222", 128);

        Console.WriteLine("### Testando Nokia ###");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\n### Testando iPhone ###");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
