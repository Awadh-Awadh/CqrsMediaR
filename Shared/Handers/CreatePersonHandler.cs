using MediatR;
using Shared.Commands;
using Shared.DTOs;
using Shared.Infra;
using Shared.Models;

namespace Shared.Handers;

public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, Person>

{
    private readonly IDataAccess _dataAccess;

    public CreatePersonHandler(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public async Task<Person> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        var person = new Person(0, request.FirstName, request.LastName);

        _dataAccess.InsertPerson(person);

        return person;

    }
}

