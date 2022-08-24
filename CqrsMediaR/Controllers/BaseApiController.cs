using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediaR.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BaseApiController : Controller
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator;

}