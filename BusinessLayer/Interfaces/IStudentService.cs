﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OL = ObjectLayer;

namespace BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        public List<OL::Student> GetAllStudents();
        public void CreateNewStudent(OL::Student student);
        public void EditStudent(OL::Student student);
        public void DeleteStudent(int id);
        public OL::Student GetStudentByID(int id);

    }
}
