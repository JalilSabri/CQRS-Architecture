using MediatR;
using AutoMapper;

public class CreateStudentRequestHandler : IRequestHandler<CreateStudentRequest, int>
{
    private readonly IStudentRepository studentRepository;
    private readonly IMapper mapper;

    public CreateStudentRequestHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        this.studentRepository = studentRepository;
        this.mapper = mapper;
    }

    public Task<int> Handle(CreateStudentRequest request, CancellationToken cancellationToken)
    {
        var addedStudent = mapper.Map<Student>(request.StudentDto);
        studentRepository.AddAsync(addedStudent);
        return Task.Run(() => { return addedStudent.Id; });
    }
}