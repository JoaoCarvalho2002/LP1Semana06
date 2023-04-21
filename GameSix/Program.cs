using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int inim;
            Console.WriteLine("Number of enemies? ");
            inim= int.Parse(Console.ReadLine());
            string [] Enemyarr = new string [3];

            object [] objarr = new string [inim];

            
            for(int i =0; i < Enemyarr.Length;i++){
                
                Console.WriteLine("Name of "+i+" foe: ");
                string nameTOGO= Console.ReadLine();
    
                Foe instance = new Foe(nameTOGO);
                instance.SetName(nameTOGO);
                instance.GetHealth();
                instance.GetShield();
            
                
            }  

            Console.WriteLine("Thank you for using this program!"); 

        }
        
    }
}
