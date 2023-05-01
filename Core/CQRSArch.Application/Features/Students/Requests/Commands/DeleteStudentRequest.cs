using MediatR;

public class DeleteStudentRequest : IRequest
{
    public int Id { get; set; }
}