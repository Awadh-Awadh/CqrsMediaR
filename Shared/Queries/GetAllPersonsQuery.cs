using MediatR;
using Shared.DTOs;
using Shared.Models;

namespace Shared.Queries;

public record GetAllPersonsQuery() : IRequest<List<PersonReadDto>>;