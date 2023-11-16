namespace PolSchool.DAL.Entities.Base
{
    public abstract class Course
    {

        public int CourseID { get; set; }
        public int Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

    }
}
