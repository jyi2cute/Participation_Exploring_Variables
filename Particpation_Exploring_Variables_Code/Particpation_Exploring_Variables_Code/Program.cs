using System.Security.Cryptography.X509Certificates;

namespace Particpation_Exploring_Variables_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 Variables
            string heroFirstName = "Jin";
            string heroLastName = "Yi";
            string heroFullName;
            string villianTitle = "Despicable Me";
            string minionTitle = "Minions";
            string villianName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;


            //Code Instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villianName = "Gru";
            minion1Name = "Kevin";
            minion2Name = "Bob";

            Console.WriteLine(heroFullName + "'s arch rival is " + villianName + " the " + villianTitle);

            //Minions
            Console.WriteLine(villianName + " the " + villianTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

            //Prepared to fight?
            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //Time to fight!

            //Villains attack our hero! Oh no!
            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");

            //Take current health, subtract damage then store new value back into the health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Minions attack
            Console.WriteLine("The evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + "damage!");

            //Take current health, subtract damage then store new value back into the health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");

            //Take current health, subtract damage then store new value back into the health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");

            //math
            //Take current health, subtract damage then store new value back into the health
            //This time using combination assignment and arithmetic operator
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //Display results onto the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //Minions have been defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated");

            //End of round buff!
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Final round of fight
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);

            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");

            //Take current health, subtract damage then store new value back into the health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStrength + " damage!");

            //math
            bossHealth = bossHealth - heroStrength;

            //Display results onto the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");

            //Results at the end
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A+'s to the winner!");
        }
    }
}
