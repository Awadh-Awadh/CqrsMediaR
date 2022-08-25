using Shared.Models;

namespace Shared.Infra;

public class DataAccess : IDataAccess
{
    public List<Person> Persons = new();
   
    public List<Person> GetAllPersons()
    {
    
    Persons.Add(new Person(1, "awadh", "said"));
    Persons.Add(new Person(2, "mwana", "said"));
    Persons.Add(new Person(3, "Jamila", "said"));
    Persons.Add(new Person(4, "shani", "said"));

    return Persons;
    }

    public Person InsertPerson(Person person)
    {
       var id = Persons.Max(x => x.Id) + 1;
       return new Person(id, person.FirstName, person.LastName);
    }
}