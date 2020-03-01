using GameTop.Interface;
using GameTop.lib;

namespace AppGameTop
{
    public class JogoFoda
    {
        private readonly  iJogador  _Jogador1;
        private readonly  iJogador  _Jogador2;

        private readonly iJogador _Jogador3;

        public JogoFoda( iJogador jogador1 , iJogador jogador2 , iJogador jogador3)
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
            _Jogador3 = jogador3;
        }
        public void IniciarJogo()
        {
       System.Console.Write(_Jogador1.Corre()) ;
       System.Console.Write(_Jogador1.Chuta()) ;
       System.Console.Write(_Jogador1.Passe()) ;


       System.Console.Write("PRÓXIMO JOGADOR \n");

       System.Console.Write(_Jogador2.Corre()) ;
       System.Console.Write(_Jogador2.Chuta()) ;
       System.Console.Write(_Jogador2.Passe()) ;

       System.Console.Write("PRÓXIMO JOGADOR \n");

       System.Console.Write(_Jogador3.Corre()) ;
       System.Console.Write(_Jogador3.Chuta()) ;
       System.Console.Write(_Jogador3.Passe()) ;
        }
    }
}