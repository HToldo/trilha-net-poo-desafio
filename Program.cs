using DesafioPOO.Models;

// Feito
class Program
{
    static void Main(string[] args)
    {
        // Instanciando um Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64, "WhatsApp");

        Console.WriteLine("\nSmartphone Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo(nokia.NomeAppNokia);

        // Instanciando um Iphone
        Console.WriteLine("\nSmartphone Iphone:");
        Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128, "Instagram");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo(iphone.NomeAppIphone);
    }
}