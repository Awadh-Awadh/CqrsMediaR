using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediaR.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BaseApiController : Controller
{
    public ProductsController(IMediator mediator) => _mediator = mediator;


    protected ISender Mediator => _mediator;

}