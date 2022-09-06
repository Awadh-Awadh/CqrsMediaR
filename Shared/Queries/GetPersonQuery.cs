using MediatR;
using Shared.DTOs;
using Shared.Models;

namespace Shared.Queries;

public record GetPersonQuery(int Id) : IRequest<PersonReadDto>;