using System.Text.Json;

namespace ConsoleMonGame
{
    class ConsoleMonFactory()
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);
            ConsoleMon dataMon = new ConsoleMon();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] typeSplit = lines[i].Split('|');
                string[] consoleMonData = typeSplit[0].Split(",");
                dataMon.name = consoleMonData[0];
                dataMon.health = int.Parse(consoleMonData[2]);
                dataMon.energy = int.Parse(consoleMonData[4]);
                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.health);
                Console.WriteLine(dataMon.energy);
            }
            
        }
        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);

                Console.WriteLine(json);
            return templates;
        }
        internal Skill CopySkill(Skill copyFrom)
        {
            Skill copyResult = new Skill();
            copyResult.name = copyFrom.name;
            copyResult.damage = copyFrom.damage;
            copyResult.element = copyFrom.element;
            return copyResult;
        }
    }


}
