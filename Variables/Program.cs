namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string heroFirstName = "Saavan";
            string heroLastName = "Tandon";
            string heroFullName;

            //begin code instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the glorious hero!");
            Console.WriteLine(heroFullName);
            Console.WriteLine("Press any key to close this window...");
            Console.ReadKey();
        }
    }
}