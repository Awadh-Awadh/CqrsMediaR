using Shared.Models;

namespace Shared.Infra;

public class DataAccess : IDataAccess
{
    public List<Person> Persons = new();

    public DataAccess()
    {
        Persons.Add(new Person(){Id = 1, FirstName = "awadh", LastName = "said"});
        Persons.Add(new Person(){Id = 2, LastName = "mwana",FirstName = "said"});
        Persons.Add(new Person() {Id = 3, FirstName = "Jamila", LastName = "said"});
        Persons.Add(new Person(){ Id = 4, FirstName = "shani", LastName = "said"});
    }
   
    public List<Person> GetAllPersons()
    {
        return Persons;
    }   

    public async Task<Person> InsertPerson(string firstName, string lastName)
    {
        var createPerson =  new Person
        {
            FirstName = firstName, 
            LastName = lastName,
            Id = Persons.Max(x => x.Id) + 1
        };

         Persons.Add(createPerson);

        await Task.CompletedTask;
        return createPerson;

    }

    public Task EventOccured(Person person, string evt)
    {
        Console.WriteLine($"Person {person.FirstName} created and {evt}");
        return Task.CompletedTask;
    }
}