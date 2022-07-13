using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class FashionlineRepository : Repository<Domain.FashionLine>
    {
        public FashionlineRepository(ISession session) : base(session)
        {
        }
    }    
    

}
