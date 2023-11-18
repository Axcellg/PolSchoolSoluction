using PolSchool.DAL.Entities.Base;

namespace PolSchool.DAL.Entities
{
    public abstract class Course : Department
    {

        public int CourseID { get; set; }
        public int Title { get; set; }
        public int Credits { get; set; }
    }
}
