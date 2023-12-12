using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.core.model;

namespace test.core.IRepositpry
{
    public interface IGenericRep<TEntity> where TEntity : IEntity
    {
        List<TEntity> GetAll();
         TEntity GetById(int id);
         void Update(TEntity entity);
         void Create(TEntity entity);
         void Delete(int Id);
    }
}
