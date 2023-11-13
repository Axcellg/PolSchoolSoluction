namespace PolSchool.DAL.Entities.Base
{
    public abstract class Person : StudentGrade, Course
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}



