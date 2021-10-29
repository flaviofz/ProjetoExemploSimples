using System.Collections.Generic;
using System.Linq;

namespace ProjetoExemplo.Business.Models
{
    public class Cliente : Entity
    {
        public Cliente(
            string nome, 
            Endereco endereco, 
            List<Telefone> telefones
        )
        {
            Nome = nome;
            Endereco = endereco;
            _telefones = telefones ?? new List<Telefone>();
        }

        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        private readonly IList<Telefone> _telefones;
        public IReadOnlyCollection<Telefone> Telefones => _telefones.ToArray();

        public void AlterarEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void AdicionarTelefone(Telefone telefone)
        {
            _telefones.ToList().ForEach(x => x.Desativar());

            _telefones.Add(telefone);
        }
    }
}