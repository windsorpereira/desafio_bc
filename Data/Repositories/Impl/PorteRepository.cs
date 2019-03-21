using Data.Model;
using Data.NHibernate;
using NHibernate;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Impl
{
    public class PorteRepository : NhRepositoryBase<Porte, int>, IPorteRepository
    {   
        IList<Porte> IPorteRepository.ObterTodos()
        {
            Cliente cli = null;

            List<Porte> portes = Session.QueryOver<Porte>()
                .JoinAlias(x => x.Clientes, () => cli, JoinType.LeftOuterJoin)
                .List().Distinct().ToList<Porte>();

            return portes;
        }
    }
}
