namespace Individuell1_2
{
    internal class Program
    {
        public static List<string> FilterStringStartWithA(string[] input)
        {
            List<string> result = new List<string>();

            foreach (string s in input)
            {
                if (s.StartsWith("a") || s.StartsWith("A"))
                    result.Add(s);
            }

            return result;

        }
        static void Main(string[] args)
        {
            string[] countries = { "Argentina", "Brasilien", "Kanada", "Australien", "Tyskland", "afghanistan" };

            var result = FilterStringStartWithA(countries);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
