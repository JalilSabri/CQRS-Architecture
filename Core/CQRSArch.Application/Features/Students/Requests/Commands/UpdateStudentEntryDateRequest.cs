using MediatR;

public class UpdateStudentEntryDateRequest : IRequest<Unit>
{
    public UpdateStudentEntryDateDto UpdateStudentEntryDateDto { get; set; }
}
