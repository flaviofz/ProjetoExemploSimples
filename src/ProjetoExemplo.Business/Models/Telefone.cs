using ProjetoExemplo.Business.Models.Enums;

namespace ProjetoExemplo.Business.Models
{
    public class Telefone
    {
        public Telefone(
            string ddd, 
            string numero, 
            ETipoTelefone tipoTelefone
        )
        {
            Ddd = ddd;
            Numero = numero;
            Ativo = true;
            TipoTelefone = tipoTelefone;
        }

        public string Ddd { get; private set; }
        public string Numero { get; private set; }
        public bool Ativo { get; private set; }
        public ETipoTelefone TipoTelefone { get; private set; }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public bool StatusAtivo() => Ativo;
    }    
}