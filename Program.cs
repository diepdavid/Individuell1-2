namespace Individuell1_2
{
    internal class Program
    {
        public static List<string> FilterStringStartWith(string letter, string[] input)
        {
            List<string> result = new List<string>();

            foreach (string s in input)
            {
                if (s.StartsWith(letter.ToLower()) || s.StartsWith(letter.ToUpper()))
                    result.Add(s);
            }

            return result;

        }

        static void CreateDirectoryAndSaveList(string letter, List<string> countries)
        {
            string uppercaseLetter = letter.ToUpper();
            string directoryPath = $"{uppercaseLetter}_countries";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory \"{directoryPath}\" is created.");
            }

            else
            {
                Console.WriteLine($"Directory \"{directoryPath}\" already exists.");
            }

            string filePath = Path.Combine(directoryPath, letter);

            File.WriteAllLines(filePath, countries);

            Console.WriteLine($"List saved to \"{filePath}\".");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Type the first letter of the countries");
            var letter = Console.ReadLine();

            string[] countries = { "Argentina", "Brasilien", "Kanada", "Australien", "Tyskland", "afghanistan", "belgien", "Bulgarien" };

            var result = FilterStringStartWith(letter, countries);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            CreateDirectoryAndSaveList(letter, result);

        }
    }
}

