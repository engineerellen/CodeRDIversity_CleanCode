namespace CleanCode.DRY
{
    internal class AnimalDRY
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Raca { get; private set; }

        public AnimalDRY(string nome, string raca)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Raca = raca;
        }

        // Método para validar nome e espécie, evitando repetição de código
        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new ArgumentException("Nome do animal não pode ser vazio.");
            }

            if (string.IsNullOrWhiteSpace(Raca))
            {
                throw new ArgumentException("Raça do animal não pode ser vazia.");
            }
        }

        // Método para retornar a descrição completa do animal
        public string ObterDescricao()
        {
            return $"{Nome} é um {Raca}.";
        }

        // Método para atualizar o nome do animal, reutilizando a validação
        public void AtualizarNome(string nome)
        {
            Nome = nome;
            Validar(); // Reutilizando a validação
        }

        // Método para atualizar a raca do animal, reutilizando a validação
        public void ObterRaca(string raca)
        {
            Raca = raca;
            Validar(); // Reutilizando a validação
        }
    }
}