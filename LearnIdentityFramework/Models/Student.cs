namespace LearnIdentityFramework.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public required string StudentName { get; set; }
        public required string StudentEmail { get; set; }
        public required string StudentPhone { get; set; } 

    }
}
