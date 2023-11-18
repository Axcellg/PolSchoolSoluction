namespace PolSchool.DAL.core
{
    public abstract class Person : EntityBase
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Discriminator { get; set; }

    }
}



