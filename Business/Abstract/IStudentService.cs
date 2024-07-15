﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
        List<Student> GetAllStudent();

    }
}
