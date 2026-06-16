using System.Windows;
using System.Windows.Threading;

namespace PointOfSale;

public partial class SplashWindow : Window
{
    public SplashWindow()
    {
        InitializeComponent();

        // Show the splash for a couple of seconds, then open the main window.
        // Later this is where I'll do real startup work instead (open the
        // database, load products, etc) and only switch once that's done.
        var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
        timer.Tick += (s, e) =>
        {
            timer.Stop();
            new MainWindow().Show();
            Close(); // close the splash so only the main window is left
        };
        timer.Start();
    }
}
