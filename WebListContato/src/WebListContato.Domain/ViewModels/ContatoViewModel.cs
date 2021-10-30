using System.ComponentModel.DataAnnotations;

namespace WebListContato.Domain.ViewModels
{
    public class ContatoViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}
