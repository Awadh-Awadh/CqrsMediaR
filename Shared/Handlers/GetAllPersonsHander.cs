using MediatR;
using Shared.Infra;
using Shared.Models;
using Shared.Queries;

namespace Shared.Handers;



public class GetAllPersonsHandler : IRequestHandler<GetAllPersonsQuery, List<Person>>
{
    private readonly IDataAccess _dataAccess;
    
    public GetAllPersonsHandler(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    public async Task<List<Person>> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
    {
        return await  Task.FromResult(_dataAccess.GetAllPersons());
    }
}