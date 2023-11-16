namespace PolSchool.DAL.Entities.Base
{
    public abstract class Student : Person
    {
        public int Id { get; set; }
        public string? EnrollmentDate { get; set; }
    }
}
