using Foundation;
using BrasilDevKit.Multiplatforma;

namespace BrasilDevKit.Multiplatforma.Platforms.iOS;
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
