using System;

public class GetAnimalByIdQueryHandler
{
    private readonly AnimalRepository _repository;

    public GetAnimalByIdQueryHandler(AnimalRepository repository)=>
        _repository = repository;

    public AnimalCQRS Handle(GetAnimalByIdQuery query)=>
        _repository.GetById(query.Id);
}
