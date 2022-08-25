using MediatR;
using Shared.Models;

namespace Shared.Queries;

public record GetAllPersonsQuery() : IRequest<List<Person>>;