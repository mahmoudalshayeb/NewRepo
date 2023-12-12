using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.core.Db;
using test.core.IRepositpry;
using test.core.model;

namespace test.infra.Repository
{
   
    public class GenericRep<TEntity> : IGenericRep<TEntity> where TEntity : class, IEntity
    {
        private readonly ModelContext context;
        public GenericRep(ModelContext context)
        {
            this.context = context;
        }
        public void Create(TEntity entity)
        {
            context.Add(entity);
        }
        public TEntity GetById(int id)
        {
           var res = context.Set<TEntity>().Where(x=>x.Id==id).FirstOrDefault();
            return res;
        }
        public void Delete(int Id)
        {
            var res = this.GetById;
            context.Remove(res);
        }

        public List<TEntity> GetAll()
        {
            var res = context.Set<TEntity>().ToList();
            return res;
        }

       

        public void Update(TEntity entity)
        {
           context.Update(entity);
        }
    }
}
