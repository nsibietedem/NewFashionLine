using FashionLine.Domain;
using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class OfficeRepository : Repository<Office>
    {
        public OfficeRepository(ISession session) : base(session)
        {
        }
    } 
    

}
