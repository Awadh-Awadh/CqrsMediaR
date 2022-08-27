using MediatR;
using Shared.DTOs;
using Shared.Models;

namespace Shared.Commands;

public record CreatePersonCommand (string FirstName, string LastName): IRequest<Person>;