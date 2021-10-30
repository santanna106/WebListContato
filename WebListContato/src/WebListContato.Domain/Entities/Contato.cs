using System;

namespace WebListContato.Domain.Entities
{
    public class Contato : BaseEntity<int>
    {
        public string Nome { get; set; }
        public string DDDTelefone { get; set; }
        public string DDDCelular { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
