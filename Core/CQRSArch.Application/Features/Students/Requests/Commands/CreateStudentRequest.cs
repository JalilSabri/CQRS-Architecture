using MediatR;

public class CreateStudentRequest : IRequest<int>
{
    public StudentDto StudentDto { get; set; }
}