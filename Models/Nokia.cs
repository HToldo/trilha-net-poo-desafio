namespace DesafioPOO.Models
{
    // Feito
    public class Nokia : Smartphone
    {

        public string NomeAppNokia { get; set; }
        public Nokia(string numero, string modelo, string imei, int memoria, string nomeAppNokia) : base(numero, modelo, imei, memoria, nomeAppNokia)
        {
            NomeAppNokia = nomeAppNokia;
        }

        public override void InstalarAplicativo(string nomeAppNokia)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeAppNokia}...");
        }

    }   // Feito
    
}