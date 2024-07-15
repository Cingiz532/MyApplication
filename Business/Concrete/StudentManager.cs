using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager(IStudentDal studentDal) : IStudentService
    {
       private readonly  IStudentDal _studentDal = studentDal;
        public void Add(Student student)
        {
            if (student.StudentPoint >= 80)
            {
                _studentDal.Add(student);
            }
            else
                Console.WriteLine("Teessufler olsunki, sizin baliniz bizim sirket ucun uygun deyil :(");
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAllStudent()
        {
            return _studentDal.GetAll();
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
