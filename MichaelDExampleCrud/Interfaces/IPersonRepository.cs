namespace MichaelDExampleCrud.Interfaces;

public interface IPersonRepository
{
    public List<IPersonModel> People { get; }

    public event EventHandler PersonRepositoryStateChanged;

    public void AddPerson(IPersonModel personModel);
}