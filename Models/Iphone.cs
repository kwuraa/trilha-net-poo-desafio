namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" //  COMPLETO !!!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" //  COMPLETO !!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no seu Iphone!");
        }
    }
}