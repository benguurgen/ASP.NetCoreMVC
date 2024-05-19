using Example05Models.Models;

namespace Example05Models.Services
{
    public class StudentService
    {
        private static List<Student> students = new List<Student>();
        public static List<Student> Students()
        {
            if(students.Any()) return students;
            students.Add(new Student() { Id=1, Name="Emre", Surname="Demir", Email="emre@mail.com", BirthDate=new DateOnly(1996,1,1),Gender=Gender.Male, StudentStatus=StudentStatus.Active});
            students.Add(new Student() { Id=2, Name="Hüseyin", Surname="Demir", Email="hsyn@mail.com", BirthDate=new DateOnly(1996,1,1),Gender=Gender.Male, StudentStatus=StudentStatus.Passive});
            students.Add(new Student() { Id=3, Name="Bengü", Surname="Demir", Email="bng@mail.com", BirthDate=new DateOnly(1995,1,1),Gender=Gender.Female, StudentStatus=StudentStatus.Active});

            return students;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
