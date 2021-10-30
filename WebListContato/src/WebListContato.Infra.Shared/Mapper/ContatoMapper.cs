using System.Collections.Generic;
using WebListContato.Domain.Entities;
using WebListContato.Domain.Interfaces;
using WebListContato.Domain.ViewModels;

namespace WebListContato.Infra.Shared.Mapper
{
    public class ContatoMapper : IMapper<Contato, ContatoViewModel>, IMapper<ContatoViewModel, Contato>
    {
        public ContatoViewModel Parse(Contato origin)
        {
            throw new System.NotImplementedException();
        }

        public List<ContatoViewModel> Parse(List<Contato> origin)
        {
            throw new System.NotImplementedException();
        }

        public Contato Parse(ContatoViewModel origin)
        {
            throw new System.NotImplementedException();
        }

        public List<Contato> Parse(List<ContatoViewModel> origin)
        {
            throw new System.NotImplementedException();
        }
    }
}
