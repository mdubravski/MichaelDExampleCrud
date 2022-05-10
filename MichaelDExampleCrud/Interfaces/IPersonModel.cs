namespace MichaelDExampleCrud.Interfaces;

public interface IPersonModel
{
    public Guid Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; }
}