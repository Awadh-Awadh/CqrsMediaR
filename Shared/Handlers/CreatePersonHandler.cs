using MediatR;
using Shared.Commands;
using Shared.DTOs;
using Shared.Infra;
using Shared.Models;

namespace Shared.Handlers;

public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, Person>

{
    private readonly IDataAccess _dataAccess;

    public CreatePersonHandler(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public async Task<Person> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        return await _dataAccess.InsertPerson(request.FirstName, request.LastName);
        
    }
}

