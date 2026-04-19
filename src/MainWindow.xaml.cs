using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lolchicer.Umlsql;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ConnectionContext ConnectionContextMain = new ConnectionContext()
    {
        ConnectionString = "Host=localhost;Port=5432;Database=usersdb;Username=username;Password=password"
    };

    public MainWindow()
    {
        InitializeComponent();

        // New binding object using the path of 'Name' for whatever source object is used
        var ConnectionStringBindingObject = new Binding("ConnectionString");

        // Configure the binding
        ConnectionStringBindingObject.Mode = BindingMode.TwoWay;
        ConnectionStringBindingObject.Source = ConnectionContextMain;

        // Set the binding to a target object. The TextBlock.Name property on the NameBlock UI element
        BindingOperations.SetBinding(ConnectionBox, TextBlock.TextProperty, ConnectionStringBindingObject);
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {

    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        var interfaceWindow = new View.InterfaceWindow(ConnectionContextMain);

        interfaceWindow.Owner = this;
        interfaceWindow.Show();
    }
}
