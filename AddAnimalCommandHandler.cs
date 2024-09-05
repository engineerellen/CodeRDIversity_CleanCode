using System;

public class AddAnimalCommandHandler
{
    private readonly AnimalRepository _repository;

    public AddAnimalCommandHandler(AnimalRepository repository)
    {
        _repository = repository;
    }

    public void Handle(AddAnimalCommand command)
    {
        var animal = new Animal
        {
            Id = Guid.NewGuid(),
            Name = command.Name,
            Species = command.Species
        };
        _repository.Add(animal);
    }
}