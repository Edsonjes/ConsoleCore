using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador2 : iJogador
    {
       
        public string Corre()
        {
            return"Maradona esta Correndo \n";
        }
       
        public string Chuta()
        {
            return"Maradona esta Chutando \n";
        }
       
        public string Passe()
        {
            return"Maradona esta Passando \n";
        }

    }
}