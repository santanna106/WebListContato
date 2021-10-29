namespace WebListContato.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
