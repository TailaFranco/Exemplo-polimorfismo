namespace Polimorfismo.classes
{
    public class Megaman : Player
    {
        private string buster;
        public string personagem = "Megaman";
        public override string Correr()
        {
            return "Correndo em velocidade 2x";
        }
    }
}