using CleanCode.DRY;
using CleanCode.KISS;
using CleanCode.YAGNI;

ChamarCQRS();

ChamarDRY();

ChamarKISS();

ChamarYAGNI();

static void ChamarCQRS()
{
    var repository = new AnimalRepository();

    // Comando: Adicionar um animal
    var objCommandHandler = new AddAnimalCommandHandler(repository);
    objCommandHandler.Handle(new AddAnimalCommand("Leão", "Felino"));

    // Consulta: Buscar um animal pelo ID
    var queryHandler = new GetAnimalByIdQueryHandler(repository);
    var animal = queryHandler.Handle(new GetAnimalByIdQuery(Guid.Parse("id-do-animal")));
}

static void ChamarDRY()
{
    var animal = new AnimalDRY("Leão", "Felino");

    // Atualizar o nome e espécie sem duplicar a lógica de validação
    animal.AtualizarNome("Tigre");
    animal.ObterRaca("Felino Grande");

    // Obter a descrição completa do animal
    Console.WriteLine(animal.ObterDescricao());
}

static void ChamarKISS()
{
    var animal = new AnimalKISS("Leão", "Felino");

    // Atualizar o nome e a espécie de maneira simples
    animal.AtualizarNome("Tigre");
    animal.AtualizarRaca("Felino Grande");

    // Obter a descrição do animal
    Console.WriteLine(animal.ObterDescricao());
}

static void ChamarYAGNI()
{
    var animal = new AnimalYAGNI("Leão", "Felino");

    // Obter a descrição do animal
    Console.WriteLine(animal.ObterDescricao());
}