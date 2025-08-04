namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public string NomeAppIphone { get; set; }

        public Iphone(string numero, string modelo, string imei, int memoria, string nomeAppIphone) 
            : base(numero, modelo, imei, memoria, nomeAppIphone)
        {
            NomeAppIphone = nomeAppIphone;
        }

        public override void InstalarAplicativo(string nomeAppIphone)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeAppIphone}...");
        }
    }
}