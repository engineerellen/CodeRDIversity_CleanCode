public class AddAnimalCommandHandler
{
    private readonly AnimalRepository _repository;

    public AddAnimalCommandHandler(AnimalRepository repository)
    {
        _repository = repository;
    }

    public void Handle(AddAnimalCommand command)
    {
        var animal = new AnimalCQRS
        {
            Id = Guid.NewGuid(),
            Name = command.Nome,
            Raca = command.Raca
        };
        _repository.Add(animal);
    }
}