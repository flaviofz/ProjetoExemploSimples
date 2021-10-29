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

        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}