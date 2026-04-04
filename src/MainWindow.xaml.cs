using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lolchicer.Umlsql;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ConnectionContext _connectionContext = new ConnectionContext()
    {
        ConnectionString = "Host=localhost;Port=5432;Database=usersdb;Username=username;Password=password"
    };

    public MainWindow()
    {
        InitializeComponent();

        // New binding object using the path of 'Name' for whatever source object is used
        var ConnectionContextMain = new Binding("ConnectionString");

        // Configure the binding
        ConnectionContextMain.Mode = BindingMode.OneWay;
        ConnectionContextMain.Source = _connectionContext;

        // Set the binding to a target object. The TextBlock.Name property on the NameBlock UI element
        BindingOperations.SetBinding(ConnectionBlock, TextBlock.TextProperty, ConnectionContextMain);
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {

    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        var interfaceWindow = new View.InterfaceWindow(_connectionContext);

        interfaceWindow.Owner = this;
        interfaceWindow.Show();
    }
}
