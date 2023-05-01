using MediatR;
using AutoMapper;

public class GetStudentCoursesListRequestHandler : IRequestHandler<GetStudentCoursesListRequest, List<CourseStudentDto>>
{
    private readonly IStudentRepository studentRepository;
    private readonly IMapper mapper;

    public GetStudentCoursesListRequestHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        this.studentRepository = studentRepository;
        this.mapper = mapper;
    }

    public async Task<List<CourseStudentDto>> Handle(GetStudentCoursesListRequest request, CancellationToken cancellationToken)
    {
        var lstStudentCourses = await studentRepository.GetCoursesByStudentIdAsync(request.StudentId);
        return mapper.Map<List<CourseStudentDto>>(lstStudentCourses);
    }

   
}
