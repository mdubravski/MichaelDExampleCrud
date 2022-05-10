using MichaelDExampleCrud.Classes;
using MichaelDExampleCrud.Interfaces;

namespace MichaelDExampleCrud.Classes;

public class PersonModel : IPersonModel 
{
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName => $"{FirstName} {LastName}";
}