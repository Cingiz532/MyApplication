using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Faculty : BaseEntity
    {
        public string FacultyName { get; set; }
        public short StudentCount { get; set; }
    }
}
