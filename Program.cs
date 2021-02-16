using System;
using System.Collections.Generic;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human humanOne = new Human("Dave");
            // Attack("Suj");
            Human humanTwo = new Human("Suj", 50, 50, 50, 50);
            humanOne.Attack(humanTwo);
        }
    }

    public class Human
    {
        // Fields for Human
        // Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        // Add an additional private field for health (int), and a public property to access or "get" health
        public int Health
        {
            get { return health; }
            // just like a regular function that takes a value (must be 'value')
            set { health = value; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        // Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
        public Human(string iName)
        {
            Name = iName;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
            Console.WriteLine($"Name: {this.Name}, Strength: {this.Strength}, Intelligence: {this.Intelligence}, Dexterity: {this.Dexterity}, Health: {this.Health}");
        }

        // Add a constructor to assign custom values to all fields
        // Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human(string iName, int iStrength, int iIntelligence, int iDexterity, int iHealth)
        {
            Name = iName;
            Strength = iStrength;
            Intelligence = iIntelligence;
            Dexterity = iDexterity;
            health = iHealth;
            Console.WriteLine($"Name: {this.Name}, Strength: {this.Strength}, Intelligence: {this.Intelligence}, Dexterity: {this.Dexterity}, Health: {this.Health}");
        }

        // Build Attack method
        // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
        // public void Attack(Human target)
        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.Health = target.Health - damage;
            Console.WriteLine($"{this.Name} has attacked {target.Name}; Damage: {damage} - Now, {target.Name}'s health is {target.Health}");
            return target.Health;
        }
    }

}
