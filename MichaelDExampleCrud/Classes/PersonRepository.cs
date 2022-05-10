using MichaelDExampleCrud.Interfaces;

namespace MichaelDExampleCrud.Classes;

public class PersonRepository : IPersonRepository
{
    private List<IPersonModel> _people = new();

    public PersonRepository()
    {
        _people.Add(new PersonModel()
        {
            FirstName = "Michael",
            LastName = "Dubravski"
        });

        _people.Add(new PersonModel()
        {
            FirstName = "Hunter",
            LastName = "Freeman"
        });

        _people.Add(new PersonModel()
        {
            FirstName = "Raymond",
            LastName = "Lei"
        });
        
        _people.Add(new PersonModel()
        {
            FirstName = "Brandon",
            LastName = "Davis"
        });
    }

    public List<IPersonModel> People => _people;

    public event EventHandler PersonRepositoryStateChanged;

    /*
     * PersonRepositoryStateChanged?.Invoke(this, EventArgs.Empty);
     */

    public void AddPerson(IPersonModel personModel)
    {
        _people.Add(personModel);

        PersonRepositoryStateChanged?.Invoke(this, EventArgs.Empty);
    }
}