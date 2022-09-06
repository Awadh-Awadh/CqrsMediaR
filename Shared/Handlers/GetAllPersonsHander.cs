using AutoMapper;
using MediatR;
using Shared.DTOs;
using Shared.Infra;
using Shared.Models;
using Shared.Queries;

namespace Shared.Handers;



public class GetAllPersonsHandler : IRequestHandler<GetAllPersonsQuery, List<PersonReadDto>>
{
    private readonly IDataAccess _dataAccess;
    private readonly IMapper _mapper;

    public GetAllPersonsHandler(IDataAccess dataAccess, IMapper mapper)
    {
        _dataAccess = dataAccess;
        _mapper = mapper;
    }
    public async Task<List<PersonReadDto>> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
    {
        var persons = _dataAccess.GetAllPersons();
        var peopleToReturn = _mapper.Map<List<PersonReadDto>>(persons);
        await Task.FromResult(peopleToReturn);
        return peopleToReturn;
    }
}