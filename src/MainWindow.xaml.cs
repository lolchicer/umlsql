using Lolchicer.Umlsql.View;
using Lolchicer.Umlsql.ViewModel;
using Microsoft.VisualBasic;
using System.IO;
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
        var connectionContext = new ConnectionContext()
        { ConnectionString = "Host=localhost;Port=5432;Database=usersdb;Username=username;Password=password" };

        if (File.Exists(@"ConnectionString.txt"))
            connectionContext = new ConnectionContext()
            { ConnectionString = File.ReadAllText(@"ConnectionString.txt") };

        Resources.Add("ConnectionContext", connectionContext);

        InitializeComponent();
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        var interfaceWindow = new ProductWindow(((ConnectionContext)this.FindResource("ConnectionContext")).ConnectionString)
        {
            Owner = this
        };
        interfaceWindow.Show();
    }

    private void SaveConnectionString(object sender, RoutedEventArgs e)
    {
        File.WriteAllText(
            @"ConnectionString.txt",
            ((ConnectionContext)this.FindResource("ConnectionContext")).ConnectionString
        );
    }
}
