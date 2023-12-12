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
    public class UserRep : GenericRep<User>, IUserRep
    {
       
        protected readonly ModelContext context;
        public UserRep(ModelContext context):base(context)
        {
            this.context = context;
        }

        public List<User> UsersByName(string UserName)
        {
            var res = context.Set<User>().Where(x=>x.UserName ==UserName).ToList();
            return res;
        }
        public void SaveChange()
        {
           context.SaveChanges();
        }
      
    }
}
