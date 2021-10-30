using System.ComponentModel.DataAnnotations;

namespace WebListContato.Domain.ViewModels
{
    public class UsuarioViewModel 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Login do Usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Informe a Senha do Usuário")]
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}
