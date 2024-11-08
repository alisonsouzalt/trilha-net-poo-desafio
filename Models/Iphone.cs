namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
         public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        // Implementação específica de InstalarAplicativo para iPhone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}