using UIKit;
using BrasilDevKit.Multiplatforma.Platforms.MacCatalyst;
using BrasilDevKit.Multiplatforma;

namespace BrasilDevKit.Multiplatforma.Platforms.MacCatalyst;
public class Program
{
    // This is the main entry point of the application.
    static void Main(string[] args)
    {
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}
