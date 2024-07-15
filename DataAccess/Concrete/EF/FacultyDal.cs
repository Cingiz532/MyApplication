using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class FacultyDal : IFacultyDal
    {
        public void Add(Faculty faculty)
        {
            Console.WriteLine($"{faculty.FacultyName} adli faculte siyahiya elave olundu");
        }

        public void Delete(Faculty faculty)
        {
            Console.WriteLine($"{faculty.FacultyName} adli faculte siyahidan silindi");
        }

        public List<Faculty> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Faculty faculty)
        {
            throw new NotImplementedException();
        }
    }
}
