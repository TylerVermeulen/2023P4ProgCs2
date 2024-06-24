namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string content = File.ReadAllText("stringsplit.txt");
            string[] keyvalue = content.Split(':');
            string[] cijfersPerVak = keyvalue[1].Split(',');

            Console.WriteLine(keyvalue[0]);
            Console.WriteLine(content);
            Console.WriteLine(cijfersPerVak[1]);
           /* for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(keyvalue);
            }*/
        }
    }
}
