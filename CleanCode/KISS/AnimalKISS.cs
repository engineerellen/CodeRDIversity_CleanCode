using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.KISS
{
    public class AnimalKISS
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Raca { get; private set; }

        // Construtor simples, inicializando as propriedades
        public AnimalKISS(string nome, string raca)
        {
            Id = Guid.NewGuid();  // Gerar um ID único
            Nome = nome;
            Raca = raca;
        }

        // Método simples para atualizar o nome
        public void AtualizarNome(string nomes)
        {
            if (string.IsNullOrWhiteSpace(nomes))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            Nome = nomes;
        }

        // Método simples para atualizar a raca
        public void AtualizarRaca(string racas)
        {
            if (string.IsNullOrWhiteSpace(racas))
            {
                throw new ArgumentException("A raça não pode ser vazia.");
            }
            Raca = racas;
        }

        // Método simples para obter uma descrição do animal
        public string ObterDescricao()
        {
            return $"{Nome} é um {Raca}.";
        }
    }
}