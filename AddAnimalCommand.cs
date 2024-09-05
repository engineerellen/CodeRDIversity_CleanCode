using System;

public class AddAnimalCommand
{
    public string Name { get; }
    public string Species { get; }

    public AddAnimalCommand(string name, string species)
    {
        Name = name;
        Species = species;
    }
}