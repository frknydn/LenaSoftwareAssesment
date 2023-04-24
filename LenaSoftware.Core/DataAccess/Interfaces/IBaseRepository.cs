using LenaSoftware.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Core.DataAccess.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
     
    }
}
