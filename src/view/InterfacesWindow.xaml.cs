using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lolchicer.Umlsql.View
{
    public partial class InterfacesWindow : Window
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

        public InterfacesWindow(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
            _applicationContext = new ApplicationContext()
            { ConnectionString = _connectionContext.ConnectionString };

            Resources.Add("ApplicationContext", _applicationContext);
            Resources.Add("Interfaces", _applicationContext.Interfaces);

            InitializeComponent();
        }
    }
}
