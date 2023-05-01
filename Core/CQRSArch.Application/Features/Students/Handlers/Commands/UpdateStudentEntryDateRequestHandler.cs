using MediatR;
using AutoMapper;

public class UpdateStudentEntryDateRequestHandler : IRequestHandler<UpdateStudentEntryDateRequest, Unit>
{
    private readonly IStudentRepository studentRepository;
    private readonly IMapper mapper;

    public UpdateStudentEntryDateRequestHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        this.studentRepository = studentRepository;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateStudentEntryDateRequest request, CancellationToken cancellationToken)
    {
        Student student = studentRepository.GetById(request.UpdateStudentEntryDateDto.Id);
        student.EntryDate = request.UpdateStudentEntryDateDto.EntryDate;
        //mapper.Map(request.UpdateStudentEntryDateDto,student);
        await studentRepository.UpdateAsync(student);
        return Unit.Value;
    }

}
