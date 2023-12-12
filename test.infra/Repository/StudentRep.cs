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
    public class StudentRep : GenericRep<Student>, IStudentRep
    {
        private readonly ModelContext context;
        public StudentRep(ModelContext context):base(context) 
        {
            this.context = context;
        }

        public Student GetStudentByUserId(int Id)
        {
            var res = context.Set<Student>().FirstOrDefault(x => x.UserId == Id);
            return res;
        }
    }
}