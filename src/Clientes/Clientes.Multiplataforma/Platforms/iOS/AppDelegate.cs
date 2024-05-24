using Foundation;
using Clientes.Multiplataforma;

namespace Clientes.Multiplataforma.Platforms.iOS;
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
