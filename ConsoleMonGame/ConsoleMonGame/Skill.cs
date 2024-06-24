namespace ConsoleMonGame
{
    internal class Skill
    {
        public int damage;
        public int energyCost;
        public string name;
        public Element element;
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(this.energyCost);
            target.TakeDamage(this.damage);
            if (target.weakness == element)
            {
                target.TakeDamage(this.damage / 2);
            }
        }
        public Skill()
        {

        }
        internal Skill(int damage, 
            int energyCost, 
            string name, 
            Element element) 
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = element;
        }


    }
}