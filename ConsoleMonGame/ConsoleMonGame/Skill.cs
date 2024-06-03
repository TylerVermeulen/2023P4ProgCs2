namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;
        internal Element element;
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(this.energyCost);
            target.TakeDamage(this.damage);
            if (target.weakness == element)
            {
                target.TakeDamage(this.damage / 2);
            }
        }


    }
}