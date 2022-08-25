using MediatR;
using Shared.Exceptions;
using Shared.Models;
using Shared.Queries;

namespace Shared.Handers;



public record GetPersonHandler : IRequestHandler<GetPersonQuery, Person>
{
    private readonly IMediator _mediator;

    public GetPersonHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    public async Task<Person> Handle(GetPersonQuery request, CancellationToken cancellationToken)
    {
        var persons = await _mediator.Send(new GetAllPersonsQuery());
        
        var person =  persons.FirstOrDefault(c => c.Id == request.Id);

        return person ?? throw new PersonNotFoundException("Person not found");



    }
}