using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LenaSoftware.Core.DataAccess.Interfaces;
using LenaSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace LenaSoftware.Core.DataAccess.EF
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _table;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            var delete = _context.Entry(entity);
            delete.State= EntityState.Deleted;
            _table.Remove(entity);
            _context.SaveChanges(); 
        }

        public List<TEntity> GetAll()
        {
            return _table.ToList();
        }
       

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }       

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
