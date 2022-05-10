using Microsoft.AspNetCore.Components;

namespace MichaelDExampleCrud.Shared;

public partial class MainLayout : LayoutComponentBase
{
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
}