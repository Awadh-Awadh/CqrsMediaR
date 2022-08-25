using MediatR;
using Shared.Models;

namespace Shared.Queries;

public record GetPersonQuery(int Id) : IRequest<Person>;