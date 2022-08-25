using Shared.Models;

namespace Shared.Infra;

public interface IDataAccess
{
    List<Person> GetAllPersons();
    Person InsertPerson(Person person);
}