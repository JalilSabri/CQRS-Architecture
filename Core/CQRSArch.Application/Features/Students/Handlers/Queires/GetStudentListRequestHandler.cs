using AutoMapper;
using MediatR;

public class GetStudentListRequestHandler : IRequestHandler<GetStudentListRequest, List<RetriveStudentDto>>
{
    
    private readonly IStudentRepository studentRepository;
    private readonly IMapper mapper;

    public GetStudentListRequestHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        this.studentRepository = studentRepository;
        this.mapper = mapper;
    }

    public async Task<List<RetriveStudentDto>> Handle(GetStudentListRequest request, CancellationToken cancellationToken)
    {
        var lstStudents = await studentRepository.GetAllAsync();
        return mapper.Map<List<RetriveStudentDto>>(lstStudents);

        //return _mapper.Map<List<StudentDto>>(await _studentRepository.GetAllAsync());
    }

}