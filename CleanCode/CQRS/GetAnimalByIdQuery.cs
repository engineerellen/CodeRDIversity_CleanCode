public class GetAnimalByIdQuery
{
    public Guid Id { get; }

    public GetAnimalByIdQuery(Guid id)=>
        Id = id;
}