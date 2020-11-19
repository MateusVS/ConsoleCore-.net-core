using GameTOP.Interfaces;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        private readonly string _Nome;
        public Jogador1(string Nome = "Ronaldo")
        {
            _Nome = Nome;
        }
        public string Chuta()
        {
            return $"{_Nome} esta chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} esta correndo \n";
        }

        public string Passa()
        {
            return $"{_Nome} esta passando \n";
        }
    }
}