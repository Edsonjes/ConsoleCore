using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador1 : iJogador
 {
     public string _Nome { get; set; }
     public Jogador1 (string Nome = "Ronaldo")
     {
         
         _Nome = Nome;
     }

 
   //Chuta
   public string Chuta ()
   {
     return $"{_Nome} Está Chutando \n" ;
   } 
   //Chutando
   public string  Corre () 
   {
     return $"{_Nome} Está Correndo \n" ;  
   }
   //Passe
   public string Passe ()
    {
       return $"{_Nome} Está Passando \n" ;
    }
 }
}