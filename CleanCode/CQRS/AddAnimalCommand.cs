public class AddAnimalCommand
{
    public string Nome { get; }
    public string Raca { get; }

    public AddAnimalCommand(string nome, string raca)
    {
        Nome = nome;
        Raca = raca;
    }
}