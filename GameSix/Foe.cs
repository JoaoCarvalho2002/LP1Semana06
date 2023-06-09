using System;

namespace GameSix
{
    class Foe
    {
        private String name;
        private float health;
        private float shield;
        public Foe(string name)
        {
            this.name = SetName(name);

            health = 100;
            shield = 0;
            
        }

        public string GetName()
        {
            return name ;
        }
        public void TakeDamage (float damage )
        {
            shield -= damage ;
            if(shield < 0 )
            {
            float damageStillToInflict = -shield;
            shield = 0 ;
            health -= damageStillToInflict;
            if(health < 0 )health = 0 ;
            }
        }

        public float GetHealth()
        {
            
            return health;
            
        }

        public float GetShield()
        {
            
            return shield ;
        }

        public string SetName(string name)
        {
            
            string trim = name.Replace( " ", "" );
            return trim;

        }
        public void PickupPowerUP(int powerup,float aux)
        {
            if (powerup==health)
            {
                if (health+aux<=100){
                    health=health+aux;
                    
                }else{
                    health=100;
                }

            }
            if (powerup==shield)
            {
                if (shield+aux<=100){
                    shield=shield+aux;
                    
                }else{
                    shield=100;
                }
                

            }
            
            

        }
    }
}
