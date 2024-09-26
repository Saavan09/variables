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

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            //begin code instructions
            heroFullName = heroFirstName + " " + heroLastName;

            //introductions
            Console.WriteLine("Behold the glorious hero of programming: " + heroFullName + "!");
            Console.WriteLine(heroFullName + "'s archnemesis is " + villainName + " the " + villainTitle + " whose minions are two " + minionTitle + "s, " + minion1Name + " and " + minion2Name + ". But they're no match for a hero as great as " + heroFirstName + "!");

            //fight!
            Console.WriteLine("The fighters enter the room anyway!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //villain attack
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFirstName + " now has " + heroHealth + " health");

            //minion attack
            Console.WriteLine("The minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFirstName + " now has " + heroHealth + " health");

            //hero attack
            Console.WriteLine(heroFullName + " attacks all enemies for " + heroStrength + " damange!");
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //display health
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //end of round buff
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats an apple to restore health");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health");

            //final round of fight
            Console.WriteLine("Hero health: " + heroHealth);
            Console.WriteLine("Boss health: " + bossHealth);

            //villain attack
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFirstName + " now has " + heroHealth + " health");

            //hero attack
            Console.WriteLine(heroFullName + " attacks the " + villainTitle + " for " + heroStrength + " damange!");
            bossHealth -= heroStrength;
            Console.WriteLine("The boss now has " + bossHealth + " health!");
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A's to the winner!");

            //end
            Console.WriteLine("Press any key to close this window...");
            Console.ReadKey();
        }
    }
}