namespace PolSchool.DAL.Entities.Base
{
    public abstract class Course :Department
    {

        public int CourseID { get; set; }
        public int Title { get; set; }
        public int Credits { get; set; }
    }
}
