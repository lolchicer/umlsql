using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lolchicer.Umlsql.View;

public partial class InterfaceWindow : Window
{
    private ConnectionContext _connectionContext;
    private ApplicationContext _applicationContext;

    public ConnectionContext ConnectionContext
    {
        get => _connectionContext;
        set => _connectionContext = value;
    }

    public string ConnectionString
    {
        get => ConnectionContext.ConnectionString;
    }

    public InterfaceWindow(ConnectionContext connectionContext)
    {
        _connectionContext = connectionContext;
        _applicationContext = new ApplicationContext()
            { ConnectionString = _connectionContext.ConnectionString };

        Resources.Add("ApplicationContext", _applicationContext);
        Resources.Add("Interface", _applicationContext.Interface);

        InitializeComponent();
    }
}
