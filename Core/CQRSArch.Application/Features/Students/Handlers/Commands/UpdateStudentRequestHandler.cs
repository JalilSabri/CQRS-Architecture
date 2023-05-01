using MediatR;
using AutoMapper;

public class UpdateStudentRequestHandler : IRequestHandler<UpdateStudentRequest, Unit>
{
    private readonly IStudentRepository studentRepository;
    private readonly IMapper mapper;

    public UpdateStudentRequestHandler(IStudentRepository studentRepository,IMapper mapper)
    {
        this.studentRepository = studentRepository;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateStudentRequest request, CancellationToken cancellationToken)
    {
        Student student = await studentRepository.GetByIdAsync(request.UpdateStudentDto.Id);
        mapper.Map(request.UpdateStudentDto, student);
        await studentRepository.UpdateAsync(student);
        return Unit.Value;
    }
}