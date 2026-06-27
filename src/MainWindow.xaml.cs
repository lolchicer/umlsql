using Lolchicer.Umlsql.View;
using Lolchicer.Umlsql.ViewModel;
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
        var interfaceWindow = new InterfacesWindow((ConnectionContext)this.FindResource("ConnectionContextMain"))
        {
            Owner = this
        };
        interfaceWindow.Show();
    }
}
