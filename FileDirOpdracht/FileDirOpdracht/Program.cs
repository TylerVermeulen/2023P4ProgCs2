namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            DirectoryInfo dir = new DirectoryInfo(@"C:\MA\Bewijzenmap periode1.4\PROG\2023P4ProgCs2");
            System.IO.FileInfo[] file = dir.GetFiles();
            for (int i = 0; i < file.Length; i++)
            {
                Console.WriteLine(file[i]);
            }
            System.IO.DirectoryInfo[] directory = dir.GetDirectories();
            for (int i = 0;i < directory.Length; i++)
            {
                Console.WriteLine(directory[i]);
            }
        }
        
    }
}
