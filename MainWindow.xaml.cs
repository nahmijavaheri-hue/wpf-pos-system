using System.Windows;
using PointOfSale.Views;

namespace PointOfSale;

public partial class MainWindow : Window
{
    // Keep one instance of each screen around so they don't get rebuilt every
    // time I switch tabs.
    private readonly SaleView _register = new();
    private readonly CatalogView _items = new();
    private readonly HistoryView _sales = new();

    public MainWindow()
    {
        InitializeComponent();
        ScreenArea.Content = _register; // start on the register screen
    }

    // Each nav button swaps which screen is shown in the content area.
    private void NavRegister_Checked(object sender, RoutedEventArgs e) => ShowScreen(_register);
    private void NavItems_Checked(object sender, RoutedEventArgs e) => ShowScreen(_items);
    private void NavSales_Checked(object sender, RoutedEventArgs e) => ShowScreen(_sales);

    private void ShowScreen(object screen)
    {
        // ScreenArea is null while the window is still loading, so guard against that.
        if (ScreenArea != null) ScreenArea.Content = screen;
    }
}
