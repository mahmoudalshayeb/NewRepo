using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.core.model;

namespace test.core.IRepositpry
{
    public interface IUnitRep
    {
        IStudentRep StudentRep { get; }
        IUserRep UserRep { get; }
        public void Complite();
    }
}
