using MediatR;

public class GetStudentCoursesListRequest : IRequest<List<CourseStudentDto>>
{
    public int StudentId { get; set; }
}