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