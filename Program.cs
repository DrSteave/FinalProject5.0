namespace FinalProject5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static (string name, string lastName, int age) GetFullInfo()
        {
            (string name, string lastName, int age) User;

            Console.Write("Type your name: ");
            var name = Console.ReadLine();

            Console.Write("Type your last name: ");
            var lastName = Console.ReadLine();

            Console.Write("Type your age: ");
            bool isAge = int.TryParse(Console.ReadLine(), out int age);
            if (!isAge)
            {
                Console.WriteLine("Type number, not letter");
            }

            Console.Write("Type \"Y\" if you have a pet. Type \"N\" if not");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("Type something");
            }

            bool isPet = false;

            switch (answer.ToLower())
            {
                case "Y":
                    isPet = true;
                    break;

                case "N":
                    isPet = false;
                    break;

                default:
                    Console.WriteLine("Unknown answer");
                    break;
            }
            string[] petNames;
            string[] favColors;

            if (isPet)
            {
                petNames = GetPetNames();
            }
            favColors = GetFavColors();
        }

        static string[] GetPetNames()
        {
            Console.Write("How many pets do you have?");
            bool isCountPet = int.TryParse(Console.ReadLine(), out int countPet);
            string[] petNames = new string[countPet];

            if (isCountPet && countPet > 0)
            { 
                for (int i = 0; i < countPet; i++)
                {
                    Console.Write("Type your pet name: {0} ", i++);
                    petNames[i] = Console.ReadLine();
                }
            }
            return petNames;
        }


        static string[] GetFavColors()
        {
            Console.Write("Write your fav colors");
            bool isfavColors = int.TryParse(Console.ReadLine(), out int countColor);

            string[] favColors = new string[countColor];

            if (isfavColors && countColor > 0)
            {
                favColors = new string[countColor];

                for (int i = 0; i < countColor; i++)
                {
                    Console.Write("Type your pet name: {0} ", i++);
                    favColors[i] = Console.ReadLine();
                }
            }
            return favColors;
        }
    }
}