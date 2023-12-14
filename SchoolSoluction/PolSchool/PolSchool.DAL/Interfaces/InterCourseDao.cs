using PolSchool.DAL.Entities;
using PolSchool.DAL.Models;

namespace PolSchool.DAL.Interfaces
{
    public interface InterCourseDao
    {
        void SaveCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
        List<ModelCourse> GetCourses();
        ModelCourse GetCourseById(int courseId);
    }
}
