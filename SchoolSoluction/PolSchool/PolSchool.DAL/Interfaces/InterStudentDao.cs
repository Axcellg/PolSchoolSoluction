using PolSchool.DAL.Entities.Base;
using PolSchool.DAL.Models;

namespace PolSchool.DAL.Interfaces
{
    public interface InterStudentDao
    {
        void saveStudent(Student student);
        void RemoveStudent(Student student);
        void UpdateStudent(Student student);

        List<ModelStudent> GetStudents();
        ModelStudent GetStudentById(int studentId);
    }
}
