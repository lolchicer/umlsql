using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lolchicer.Umlsql.View;

public partial class InterfaceWindow : Window
{
    private ConnectionContext _connectionContext;

    private void InterfaceWindow_Loaded(object sender, RoutedEventArgs e)
    {
        // Make a new data source object
        var applicationContext = new ApplicationContext()
        {
            ConnectionString = _connectionContext.ConnectionString
        };

        // New binding object using the path of 'Name' for whatever source object is used
        var ApplicationContextMain = new Binding("ConnectionString");

        // Configure the binding
        ApplicationContextMain.Mode = BindingMode.OneWay;
        ApplicationContextMain.Source = applicationContext;
    }

    public InterfaceWindow(ConnectionContext connectionContext)
    {
        _connectionContext = connectionContext;
        InitializeComponent();
    }
}
