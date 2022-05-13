using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LorealDAL.Abstract
{
   public interface IRepositoryBase<TEntity> where TEntity : class, new()
    {
        public int Add(TEntity input);
        public int Delete (TEntity input);
        public int Update (TEntity input);
        public TEntity GetById(int id) ;
        public IList<TEntity> GetAll( Expression<Func<TEntity,bool>> filter = null);




    }
}
