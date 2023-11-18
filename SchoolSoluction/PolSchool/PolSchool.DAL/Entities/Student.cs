using PolSchool.DAL.core;

namespace PolSchool.DAL.Entities.Base
{
    public partial class Student : Person
    {
        public int Id { get; set; }
        public DateTime? EnrollmentDate { get; set; }

    }
}
