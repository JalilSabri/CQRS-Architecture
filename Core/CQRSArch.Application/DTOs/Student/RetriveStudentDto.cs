public class RetriveStudentDto : StudentDto
{
    public string FullName { get { return $"{FirstName} {LastName}"; } }
}