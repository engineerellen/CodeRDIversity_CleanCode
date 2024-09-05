using System;

public class AnimalRepository
{
    private readonly List<Animal> _animals = new List<Animal>();

    public void Add(Animal animal)
    {
        _animals.Add(animal);
    }

    public Animal GetById(Guid id)
    {
        return _animals.FirstOrDefault(a => a.Id == id);
    }
}