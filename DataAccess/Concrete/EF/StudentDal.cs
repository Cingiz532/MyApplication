using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class StudentDal : IStudentDal
    {

        private readonly List<Student> _student;
        public StudentDal()
        {
            _student = new List<Student>()
            {
                new Student() { Id = 1, StudentFirstName = "Cingiz", StudentLastName = "Zaidov", StudentPoint = 87, IsPassed = true },
                new Student() { Id = 2, StudentFirstName = "Ibrahim", StudentLastName = "Ezimli", StudentPoint = 79,Description = "Adnsuda 2-ci kurs telebesidir" },
                new Student() {Id=3, StudentFirstName="Eli", StudentLastName= "Musali", StudentPoint=81,IsPassed=true, Description="Azmiu da 4-cu kurs telebesidir"}
            };
        }
        public void Add(Student student)
        {
            _student.Add(student);
        }
        public void Delete(Student student)
        {
            Student deleteStudent = _student.SingleOrDefault(s => s.Id == student.Id);
            if(deleteStudent != null)
            {
                _student.Remove(deleteStudent);
            }
            else
                Console.WriteLine("Telebe tapilmadi");
        }
        public void Update(Student student)
        {
            Student updateStudent = _student.SingleOrDefault(s=>s.Id== student.Id);
            if (updateStudent != null)
            {
                student.StudentFirstName = updateStudent.StudentFirstName;
                student.StudentLastName = updateStudent.StudentLastName;
                student.StudentPoint = updateStudent.StudentPoint;
                student.Description = updateStudent.Description;
                student.IsPassed = updateStudent.IsPassed;
            }
            else
                Console.WriteLine("Telebenin melumatlari ucun yenilik yoxdur");
        }

        public List<Student> GetAll()
        {
            return _student.Where(s => s.IsPassed == true).ToList();
        }   
    }
}
