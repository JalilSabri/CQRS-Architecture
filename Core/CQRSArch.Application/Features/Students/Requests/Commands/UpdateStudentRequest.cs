using MediatR;

public class UpdateStudentRequest : IRequest<Unit>
{
    public UpdateStudentDto UpdateStudentDto { get; set; }
}