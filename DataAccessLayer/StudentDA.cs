using AutoMapper;
using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using OL = ObjectLayer;

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
            List<Student> resultFromDB = _dBContext.Students.ToList();
            List<OL::Student> result = new List<OL::Student>();
            foreach(Student _student in resultFromDB)
            {
                OL::Student student = _mapper.Map<OL::Student>(_student);
                result.Add(student);
            }
            return result;

        }
    }
}