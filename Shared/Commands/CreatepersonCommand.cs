using MediatR;
using Shared.DTOs;
using Shared.Models;

namespace Shared.Commands;

// need to pass a dto instead of the entire entity 
// and return a dto
public record CreatePersonCommand (string FirstName, string LastName): IRequest<Person>;