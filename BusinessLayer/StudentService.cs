using BusinessLayer.Interfaces;
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
        public void DeleteStudent(int id)
        {
            _studentDA.DeleteStudent(id);
        }
        public OL::Student GetStudentByID(int id)
        {
           return _studentDA.GetStudentByID(id);
        }

    }
}