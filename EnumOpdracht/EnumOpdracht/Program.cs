namespace EnumOpdracht
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            Colors myMainThemeColor = Colors.Tulip;
            if (myMainThemeColor == Colors.Tulip)
            {
                Console.WriteLine("dat is mijn kleur");
            }
        }
        
    }
}
