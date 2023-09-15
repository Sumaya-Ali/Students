﻿using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using OL = ObjectLayer;

namespace BusinessLayer
{
    public class StudentService:IStudentService
    {
        private readonly IStudentDA _studentDA;

        public StudentService(IStudentDA studentDA)
        {
            _studentDA=studentDA;
        }

        public List<OL::Student> GetAllStudents() {
           return _studentDA.GetAllStudents();
        }

        public void CreateNewStudent(OL::Student student)
        {
            _studentDA.CreateNewStudent(student);
        }
        public void EditStudent(OL::Student student)
        {
            _studentDA.EditStudent(student);
        }
        public OL::Student EditStudent(int id)
        {
           return _studentDA.EditStudent(id);
        }

    }
}