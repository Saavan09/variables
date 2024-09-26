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
            string villainTitle = "Lord of Darkness";
            string minionTitle = "Background Grunt";
            string villainName = "Steve";
            string minion1Name = "Joe";
            string minion2Name = "Shmoe";

            //begin code instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the glorious hero of programming: " + heroFullName + "!");
            Console.WriteLine("Press any key to close this window...");
            Console.ReadKey();
        }
    }
}