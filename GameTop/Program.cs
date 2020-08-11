using System;
using GameTOP.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoMassa(
                new Jogador2(), 
                new Jogador3()
                );
            jogo.IniciarJogo();
        }
    }

}
