namespace FileIOopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             File.AppendAllLines("leesdezefile.txt", new string[] { "yipeee" });
             string[] content = File.ReadAllLines("leesdezefile.txt");

            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
            if (Directory.Exists("output") == false)
            {
                Directory.CreateDirectory("output");
            }
        }
    }
}
