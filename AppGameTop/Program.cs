using System;
using GameTop.lib;
using GameTop.Interface;

namespace AppGameTop
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new JogoFoda( 
            new Jogador1(),
            new Jogador2(),
            new Jogador3()
           
           );
           jogo.IniciarJogo();
        }
    }
    

 

    
}
