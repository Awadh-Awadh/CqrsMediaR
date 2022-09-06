using AutoMapper;
using MediatR;
using Shared.DTOs;
using Shared.Exceptions;
using Shared.Infra;
using Shared.Models;
using Shared.Queries;

namespace Shared.Handers;



public record GetPersonHandler : IRequestHandler<GetPersonQuery, PersonReadDto>
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly IDataAccess _dataAccess;


    public GetPersonHandler(IMediator mediator, IMapper mapper, IDataAccess dataAccess)
    {
        _mediator = mediator;
        _mapper = mapper;
        _dataAccess = dataAccess;
    }
    public async Task<PersonReadDto> Handle(GetPersonQuery request, CancellationToken cancellationToken)
    {
        // var persons = await _mediator.Send(new GetAllPersonsQuery());
        //
        // var person =  persons.FirstOrDefault(c => c.Id == request.Id);

        var person =  _dataAccess.GetAllPersons().FirstOrDefault(p => p.Id == request.Id);
        var returnedPerson = _mapper.Map<PersonReadDto>(person);

        return returnedPerson ?? throw new PersonNotFoundException("Person not found");



    }
}