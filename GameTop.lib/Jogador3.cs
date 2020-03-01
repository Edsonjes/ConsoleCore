using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador3 : iJogador 
    {
        public string Corre()
        {
            return"Merssi esta Correndo \n";
        }
       
        public string Chuta()
        {
            return"Merssi esta Chutando \n";
        }
       
        public string Passe()
        {
            return"Merssi esta Passando \n";
        }
    }
}