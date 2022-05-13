using LorealDAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace CoreRepository

{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity> where TEntity : class, new() where TContext : DbContext, new()

    {

        protected TContext db;

        public RepositoryBase();
        {}
        public int Add(TEntity input)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity input)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity input)
        {
            throw new NotImplementedException();
        }
    }
}
