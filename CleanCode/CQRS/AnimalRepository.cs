public class AnimalRepository
{
    public readonly List<AnimalCQRS> _animals = new List<AnimalCQRS>();

    public void Add(AnimalCQRS animal) =>
        _animals.Add(animal);

    public AnimalCQRS GetById(Guid id) =>
            _animals.FirstOrDefault(a => a.Id == id);

}