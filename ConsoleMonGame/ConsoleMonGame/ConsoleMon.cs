namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal string name;
        internal int energy;
        internal int health;

        private List<Skill> skills = new List<Skill>();

        internal void TakeDamage(int damage)
        {
            health = health - damage;
        }
        internal void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
    }
}