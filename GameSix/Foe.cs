using System;

namespace GameSix
{
    public class Foe
    {
        private String name;
        private float health;
        private float shield;
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}
