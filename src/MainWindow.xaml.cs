using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lolchicer.Umlsql;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {

    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        var interfaceWindow = new View.InterfaceWindow(
            (ConnectionContext)this.FindResource("ConnectionContextMain")
            );

        interfaceWindow.Owner = this;
        interfaceWindow.Show();
    }
}
