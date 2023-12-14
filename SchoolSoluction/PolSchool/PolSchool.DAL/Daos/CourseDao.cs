

using PolSchool.DAL.Context;
using PolSchool.DAL.Entities;
using PolSchool.DAL.Entities.Base;
using PolSchool.DAL.Exceptions;
using PolSchool.DAL.Interfaces;
using PolSchool.DAL.Models;
using System.Reflection.Metadata;

namespace PolSchool.DAL.Daos
{
    public class CourseDao 
    {
       
          /*  private readonly SchoolDbContext schoolDb;

            public CourseDao(SchoolDbContext schoolDb)
            {
                this.schoolDb = schoolDb;
            }

            public ModelCourse GetCourseById(int courseId)
            {
                ModelCourse model = new ModelCourse();
                try
                {
                   Course? course = schoolDb.Courses.Find(courseId);

                    if (course is null)
                        throw new CourseExceptionsDao("No se encuentra registrado.");


                model.CreationDate = course.CreationDate;
                model.EnrollmentDate = course.EnrollmentDate;
                model.DepartmentId = course.DepartmentId;
                model.DepartmentName = course.DepartmentName;
                model.CourseId = course.CourseID;
                model.Name = string.Concat(course.Title, " ");


            }
            catch (Exception ex)
                {
                    throw new CourseExceptionsDao(ex.Message);
                }
                return model;
            }

            public List<ModelCourse> GetCourses()
            {
                List<ModelCourse> courses = new List<ModelCourse>();
                try
                {
                    ///LINQ QUERY
                    var query = from st in this.schoolDb.Courses
                                where st.Deleted == false
                                orderby st.CreationDate descending
                                select new ModelCourse()
                                {
                                    CreationDate = st.CreationDate,
                                    EnrollmentDate = st.EnrollmentDate.Value,
                                   
                                };

                    Course = query.ToList();

                }
                catch (Exception ex)
                {
                    throw new CourseExceptionsDao(ex.Message);
                }
                return Course;
            }


            public void SaveCourse(Course course)
            {
                try
                {
                    if (Course is null)
                        throw new CourseExceptionsDao("la clase debe de ser instaciada.");


                    this.schoolDb.Courses.Add(course);
                    this.schoolDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new StudentExceptionsDao(ex.Message);
                }
            }

            public void RemoveCourse(Course course)
            {
                try
                {
                    Student? studentToRemove = this.schoolDb.Students.Find(student.Id);

                    if (studentToRemove is null)
                        throw new StudentExceptionsDao("No se encuentra registrado.");


                    studentToRemove.Deleted = student.Deleted;
                    studentToRemove.DeletedDate = student.DeletedDate;
                    studentToRemove.UserDeleted = student.UserDeleted;

                    this.schoolDb.Students.Update(studentToRemove);
                    this.schoolDb.SaveChanges();

                }
                catch (Exception ex)
                {

                    throw new StudentExceptionsDao(ex.Message);
                }
            }

            public void UpdateStudent(Student student)
            {
                try
                {
                    Student? studentToUpdate = this.schoolDb.Students.Find(student.Id);

                    if (studentToUpdate is null)
                        throw new StudentExceptionsDao("No se encuentra registrado.");


                    studentToUpdate.ModifyDate = student.ModifyDate;
                    studentToUpdate.UserMod = student.UserMod;
                    studentToUpdate.Id = student.Id;
                    studentToUpdate.LastName = student.LastName;
                    studentToUpdate.FirstName = student.FirstName;
                    studentToUpdate.EnrollmentDate = student.EnrollmentDate.Value;


                    this.schoolDb.Students.Update(studentToUpdate);
                    this.schoolDb.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new StudentExceptionsDao(ex.Message);
                }
            }*/

    }
}
