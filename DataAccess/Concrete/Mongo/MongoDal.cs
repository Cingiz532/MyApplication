using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Mongo
{
    public class MongoDal : IStudentDal
    {
        public void Add(Student student)
        {
            Console.WriteLine($"{student.StudentFirstName} adli telebe siyahiya elave olundu");
        }

        public void Delete(Student student)
        {
            Console.WriteLine($"{student.StudentFirstName} adli telebe siyahidan silindi");
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
