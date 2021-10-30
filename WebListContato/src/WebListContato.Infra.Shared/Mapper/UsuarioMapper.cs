using System.Collections.Generic;
using System.Linq;
using WebListContato.Domain.Entities;
using WebListContato.Domain.Interfaces;
using WebListContato.Domain.ViewModels;

namespace WebListContato.Infra.Shared.Mapper
{
    public class UsuarioMapper : IMapper<Usuario, UsuarioViewModel>, IMapper<UsuarioViewModel, Usuario>
    {
        public UsuarioViewModel Parse(Usuario origin)
        {
            if (origin == null) return null;
            return new UsuarioViewModel
            {
                Id = origin.Id,
                Login = origin.Login,
                Nome = origin.Nome,
                Senha = origin.Senha,
            };
        }

        public Usuario Parse(UsuarioViewModel origin)
        {
            if (origin == null) return null;
            return new Usuario
            {
                Id = origin.Id,
                Login = origin.Login,
                Nome = origin.Nome,
                Senha = origin.Senha,
            };
        }

        public List<UsuarioViewModel> Parse(List<Usuario> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<Usuario> Parse(List<UsuarioViewModel> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
