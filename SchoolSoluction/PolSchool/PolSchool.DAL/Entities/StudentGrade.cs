namespace PolSchool.DAL.Entities
{
    public class StudentGrade
    {
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }

    }
}
