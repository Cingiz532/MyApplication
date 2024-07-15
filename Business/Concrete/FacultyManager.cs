using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FacultyManager(IFacultyDal facultyDal) : IFacultyService
    {
        IFacultyDal _faculty = facultyDal;
        public void Add(Faculty faculty)
        {
            if(faculty.FacultyName.Length>5)
            {
                _faculty.Add(faculty);
            }
            else Console.WriteLine("Bele bir faculte yoxdur");
        }
    }
}
