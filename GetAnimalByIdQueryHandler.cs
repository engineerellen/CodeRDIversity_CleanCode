using System;

public class GetAnimalByIdQueryHandler
{
    private readonly AnimalRepository _repository;

    public GetAnimalByIdQueryHandler(AnimalRepository repository)
    {
        _repository = repository;
    }

    public Animal Handle(GetAnimalByIdQuery query)
    {
        return _repository.GetById(query.Id);
    }
}
