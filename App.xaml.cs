using System.Windows;

namespace PointOfSale;

public partial class App : Application
{
    // App starts here. I show the splash screen first instead of going straight
    // to the main window - the splash decides when to open the main window.
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        new SplashWindow().Show();
    }
}
