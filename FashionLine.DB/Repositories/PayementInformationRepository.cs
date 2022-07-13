using FashionLine.Domain;
using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class PayementInformationRepository : Repository<Order>
    {
        public PayementInformationRepository(ISession session) : base(session)
        {
        }
    }
    

}
