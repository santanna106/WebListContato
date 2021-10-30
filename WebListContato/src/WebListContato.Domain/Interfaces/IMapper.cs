using System.Collections.Generic;

namespace WebListContato.Domain.Interfaces
{
    public interface IMapper<O, D>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
