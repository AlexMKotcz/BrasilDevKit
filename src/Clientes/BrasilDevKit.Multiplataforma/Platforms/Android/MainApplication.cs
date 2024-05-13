using Android.App;
using Android.Runtime;
using BrasilDevKit.Multiplatforma;

namespace BrasilDevKit.Multiplatforma.Platforms.Android;
[Application]
public class MainApplication(IntPtr handle, JniHandleOwnership ownership) : MauiApplication(handle, ownership)
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
