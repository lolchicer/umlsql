using Lolchicer.Umlsql.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Lolchicer.Umlsql.View
{
    public partial class ConnectionPage : Page
    {
        public ConnectionContext ConnectionContext
        {
            get => (ConnectionContext)FindResource("ConnectionContext");
        }

        public ConnectionPage()
        {
            var connectionContext = new ConnectionContext()
            { ConnectionString = "Host=localhost;Port=5432;Database=usersdb;Username=username;Password=password" };

            if (File.Exists(@"ConnectionString.txt"))
                connectionContext = new ConnectionContext()
                { ConnectionString = File.ReadAllText(@"ConnectionString.txt") };

            Resources.Add("ConnectionContext", connectionContext);

            InitializeComponent();
        }

        private void SaveConnectionString(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(
                @"ConnectionString.txt",
                ((ConnectionContext)this.FindResource("ConnectionContext")).ConnectionString
            );
        }

        private void NavigateProductPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new ProductPage(ConnectionContext.ConnectionString)
                );
        }
    }
}
