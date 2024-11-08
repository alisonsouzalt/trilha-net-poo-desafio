using System.Dynamic;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
       public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        // Implementação específica de InstalarAplicativo para Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }

    }
}