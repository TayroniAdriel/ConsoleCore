using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return ("Tayroni esta chutando \n");
        }

        public string Corre()
        {
            return ("Tayroni esta correndo \n");
        }

        public string Passe()
        {
            return ("Tayroni esta passando \n");
        }
    }
}