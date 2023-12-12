using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.core.model
{
    public class Student:Entity
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set;}
        public virtual int UserId { get; set; }
        public virtual User User { get; set; } 

    }
}
