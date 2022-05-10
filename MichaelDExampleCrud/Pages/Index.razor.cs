using MichaelDExampleCrud.Classes;
using MichaelDExampleCrud.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MichaelDExampleCrud.Pages;

public partial class Index : ComponentBase, IDisposable
{
    [Inject]
    private IPersonRepository PersonRepository { get; set; } = null!;

    protected override void OnInitialized()
    {
        PersonRepository.PersonRepositoryStateChanged += PersonRepositoryOnPersonRepositoryStateChanged;

        base.OnInitialized();
    }

    private async void PersonRepositoryOnPersonRepositoryStateChanged(object? sender, EventArgs e)
    {
        await InvokeAsync(StateHasChanged);
    }

    private void AddPerson()
    {
        PersonRepository.AddPerson(new PersonModel
        {
            FirstName = "Brandon",
            LastName = "Davis"
        });
    }

    public void Dispose()
    {
        PersonRepository.PersonRepositoryStateChanged -= PersonRepositoryOnPersonRepositoryStateChanged;
    }
}