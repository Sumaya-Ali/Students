using AutoMapper;
using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using MO=DataAccessLayer.Models;
using ObjectLayer;
using OL = ObjectLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class StudentDA : IStudentDA
    {
        private readonly ApplicationDBContext _dBContext;
        
        private readonly IMapper _mapper;

        public StudentDA(ApplicationDBContext dBContext,IMapper mapper)
        {
            _dBContext= dBContext;
            _mapper = mapper;
        }

        public List< OL::Student> GetAllStudents()
        {
            List<MO::Student> resultFromDB = _dBContext.Students.ToList();
            List<OL::Student> result = new List<OL::Student>();
            foreach(MO::Student _student in resultFromDB)
            {
                OL::Student student = _mapper.Map<OL::Student>(_student);
                result.Add(student);
            }
            return result;

        }

        public void CreateNewStudent(OL::Student student)
        {
            MO::Student _student = _mapper.Map<MO::Student>(student);
            _dBContext.Students.Add(_student);
            _dBContext.SaveChanges();
            
        }

        public void EditStudent(OL::Student student)
        {
            MO::Student _student = _mapper.Map<MO::Student>(student);
            _dBContext.Students.Update(_student);
            _dBContext.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            var student = _dBContext.Students.Find(id);
            if (student != null)
            {
                _dBContext.Students.Remove(student);
                _dBContext.SaveChanges();

            }
        }

        public OL::Student GetStudentByID(int id)
        {

            var _student = _dBContext.Students.Find(id);
            if (_student == null)
            {
                return null;
            }
            else
            {
                OL::Student student = _mapper.Map<OL::Student>(_student);
                return student;
            }
            
        }
    }
}