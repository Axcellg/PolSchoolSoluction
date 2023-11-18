using PolSchool.DAL.core;
using PolSchool.DAL.Entities.Base;

namespace PolSchool.DAL.Entities
{
    public abstract class Course : EntityBase
    {

        public int CourseID { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

    }
}
