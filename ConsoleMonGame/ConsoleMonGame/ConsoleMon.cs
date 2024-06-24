namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public string name;
        public int energy;
        public int health;
        public Element weakness;

        internal List<Skill> skills = new List<Skill>();

        internal void TakeDamage(int damage)
        {
            health = health - damage;
        }
        internal void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
        public ConsoleMon()
        {

        }
        internal ConsoleMon(int health, 
            int energy, 
            string name, 
            Element weakness) 
        { 
            this.health = health;
            this.energy = energy;
            this.weakness = weakness;
            this.name = name;
        }
    }
}