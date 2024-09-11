using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.YAGNI
{
    public class AnimalYAGNI
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Raca { get; private set; }

        // Construtor simples, inicializando apenas os campos necessários
        public AnimalYAGNI(string nome, string raca)
        {
            Id = Guid.NewGuid();  // Gerar um ID único
            Name = nome;
            Raca = raca;
        }

        // Método para obter uma descrição do animal
        public string ObterDescricao()=>
             $"{Name} é um {Raca}.";
    }
}