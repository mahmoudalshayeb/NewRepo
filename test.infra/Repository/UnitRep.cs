using test.core.Db;
using test.core.IRepositpry;

namespace test.infra.Repository
{
    public class UnitRep : IUnitRep
    {
        private IStudentRep studentRep;
        private readonly IUserRep userRep;
        private readonly ModelContext context;

        public UnitRep(ModelContext context, IStudentRep studentRep, IUserRep userRep) 
        {
           
            this.studentRep = studentRep;
            this.userRep = userRep;
            this.context = context;
        }
        IStudentRep IUnitRep.StudentRep => studentRep;
        IUserRep IUnitRep.UserRep => userRep;
        public void Complite()
        {
            context.SaveChanges();
        }
    }
}
