using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student : BaseEntity
    {
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal StudentPoint { get; set; }
        public bool IsPassed { get; set; } = false;
    }
}
