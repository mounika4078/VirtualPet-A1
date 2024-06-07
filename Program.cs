using System;



public class VirtualPet
{
    public string Type { get; private set; }
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }

    public VirtualPet(string type, string name)
    {
        Type = type;
        Name = name;
        Hunger = 8;     
        Happiness = 3;
        Health = 5;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the Virtual Pet Simulator!");
        Console.WriteLine($"You have a {Type} named {Name}.");
    }
    public void DisplayStats()
    {
        Console.WriteLine($"Pet Stats - Hunger: {Hunger}, Happiness: {Happiness}, Health: {Health}");
    }
    public void Feed()
    {
        Hunger--;
        if (Hunger < 0)
        {
            Hunger = 0;
        }

        Health++;
        if (Health > 10)
        {
            Health = 10;
        }
        Console.WriteLine($"{Name} has been fed. Hunger decreased, and health slightly increased.");
    }
    public void Play()
    {
        if (Hunger > 7)
        {
            Console.WriteLine($"{Name} is too hungry to play. Please feed the pet first.");
        }
        else
        {
            Happiness++;

            if (Happiness > 10)
            {
                Happiness = 10;
            }

            Console.WriteLine($"{Name} has played. Happiness increased, and hunger slightly increased.");

            Hunger--; // Increase hunger value slightly after playing
        }
    }




}


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");

        Console.Write("Enter pet type (e.g., cat, dog, rabbit): ");
        string petType = Console.ReadLine();

        Console.Write("Enter  your pet namesss");
        string petName = Console.ReadLine();

      

       
    }
}