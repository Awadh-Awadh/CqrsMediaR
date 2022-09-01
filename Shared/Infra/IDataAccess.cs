using Shared.Models;

namespace Shared.Infra;

public interface IDataAccess
{
    List<Person> GetAllPersons();
    Task<Person> InsertPerson(string firstName, string lastName);

    Task EventOccured(Person person , string evt);
}