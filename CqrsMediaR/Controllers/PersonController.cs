using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Queries;

namespace CqrsMediaR.Controllers;

[ApiController]
[Route("Persons")]
public class PersonController : Controller

{
    private readonly IMediator _mediator;

    public PersonController( IMediator mediator) => _mediator = mediator;
   
    [HttpGet]

    public async Task<ActionResult<List<Person>>> GetPersons()
    {
        
        var people = await  _mediator.Send( new GetAllPersonsQuery());
        return Ok(people);

    }

    [HttpGet("{id:int}", Name = "GetPerson")]

    public async Task<ActionResult<Person>> GetPerson(int id)
    {
        try
        {
            var person = await _mediator.Send(new GetPersonQuery(id));

            return Ok(person);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
       
    }
}
