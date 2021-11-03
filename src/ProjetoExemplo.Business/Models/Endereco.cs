namespace ProjetoExemplo.Business.Models
{
    public class Endereco
    {
        public Endereco(
            string cep, 
            string bairro, 
            string cidade, 
            string estado
        )
        {
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }
}