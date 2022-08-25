namespace Shared.Exceptions;

public class PersonNotFoundException : Exception
{
    public PersonNotFoundException(string message) : base(message)
    {
        
    }
}