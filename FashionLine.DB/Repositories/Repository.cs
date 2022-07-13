using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public Repository(ISession session)
        {
            Session = session;
        }

        public void Add(T entity)
        {
            Session.Save(entity);
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            Session.Delete(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        private ISession Session { get; set; }

    }
}
