

using Business.Concrete;
using DataAccess.Concrete.EF;
using DataAccess.Concrete.Mongo;
using Entities.Concrete;

StudentManager studentManager = new StudentManager(new StudentDal());

Student student1 = new Student();
student1.StudentFirstName = "Ruslan";
student1.StudentPoint = 89;
student1.IsPassed=false;
studentManager.Add(student1);



var print = studentManager.GetAllStudent();
foreach (var List in print)
{
    Console.WriteLine(List.StudentFirstName);
}

FacultyManager facultyManager = new FacultyManager( new FacultyDal());
Faculty faculty1 = new Faculty();
faculty1.FacultyName = "Cyber Security";
faculty1.Id = 1;
faculty1.StudentCount = 30;
facultyManager.Add(faculty1);
Faculty faculty2= new Faculty();
faculty2.Id = 2;
faculty2.StudentCount = 30;
faculty2.FacultyName = "IT";

