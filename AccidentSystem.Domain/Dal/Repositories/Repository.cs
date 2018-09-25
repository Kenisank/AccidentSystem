using AccidentSystem.Domain.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal.Repositories
{
    public class Repository<TEntity>:IRepository<TEntity> where TEntity:class
    {

        private readonly DbContext _context;
        private readonly DbSet DbSet;

        public Repository(DbContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {

            return _context.Set<TEntity>().Find(id);
        }



        public IEnumerable<TEntity> Getall()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);


        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }



    }
}
