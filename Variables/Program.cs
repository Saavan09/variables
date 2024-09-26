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
            Console.WriteLine(heroFullName + "'s archnemesis is " + villainName + " the " + villainTitle + " whose minions are two " + minionTitle + "s, " + minion1Name + " and " + minion2Name + ". But they're no match for a hero as great as " + heroFirstName + "!");
            Console.WriteLine("Press any key to close this window...");
            Console.ReadKey();
        }
    }
}