using MediatR;
using AutoMapper;

public class DeleteStudentRequestHandler : IRequestHandler<DeleteStudentRequest>
{
    private readonly IStudentRepository studentRepository;
    private readonly IMapper mapper;

    public DeleteStudentRequestHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        this.studentRepository = studentRepository;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteStudentRequest request, CancellationToken cancellationToken)
    {
        Student student = studentRepository.GetById(request.Id);
        if (student != null)
           await studentRepository.DeleteAsync(student);
        return Unit.Value;
    }
}
