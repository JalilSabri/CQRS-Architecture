using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MediatR;

public class IndexModel : PageModel
{
    private readonly IMediator _mediator;

    public IndexModel(IMediator mediator)
    {
        //_mediator = mediator;
    }

    //private readonly IMediator _mediator;
    //public IndexModel(IMediator mediator)
    //{
    //    this._mediator = mediator;
    //}

    public IActionResult OnGet()
    {
        //var lstStudent = _mediator.Send(new GetStudentListRequest());
        ViewData["Message"] = "This is index page....";
        return Page();
    }

}
