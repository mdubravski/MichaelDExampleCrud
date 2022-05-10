using MichaelDExampleCrud.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace MichaelDExampleCrud.Components
{
    public partial class PersonTableDisplay : ComponentBase, IDisposable
    {
        [Inject]
        private IPersonRepository PersonRepository { get; set; } = null!;
        public event EventHandler PersonTableDisplayStateChanged = null!;
        private MudTable<IPersonModel> _mudTable =  null!;

        //public event EventHandler PersonTableDisplayStateChanged;

        /*
         * Using a BlazorLife cycle method subscribe to the "event"
         *
         * Using Dispose() unsubscribe to the "event"
         *
         * Subscribe with a method as to allow for a "variable" such that
         *      you can reference the method when unsubscribing as well otherwise
         *      you can have a memory leak if forgetting to unsubscribe or not having
         *      a reference to what you subscribed with.
         *
         *  Subscribe with "async void" not "async task" 99% of time though use "async task" otherwise
         */

        protected override void OnInitialized()
        {
            PersonTableDisplayStateChanged += PersonTableDisplayOnPersonTableDisplayChanged;
            base.OnInitialized();
        }

        private async void PersonTableDisplayOnPersonTableDisplayChanged(object? sender, EventArgs e)
        {
            await _mudTable.ReloadServerData();
            await InvokeAsync(StateHasChanged);
        }


        public void Dispose()
        {
            PersonTableDisplayStateChanged -= PersonTableDisplayOnPersonTableDisplayChanged;
        }
    }
}
