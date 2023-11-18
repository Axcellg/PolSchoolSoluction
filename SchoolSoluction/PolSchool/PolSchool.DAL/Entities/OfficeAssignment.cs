namespace PolSchool.DAL.Entities.Base
{
    public partial class OfficeAssignment
    {
        public int InstructorID { get; set; }
        public string? Location { get; set; }
        public byte[]? Timestamp { get; set; }
    }
}
