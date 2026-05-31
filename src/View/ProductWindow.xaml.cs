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
using System.Windows.Shapes;

namespace Lolchicer.Umlsql.View
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private ApplicationContext _applicationContext;

        public ProductWindow(string connectionString)
        {
            _applicationContext = new ApplicationContext()
            { ConnectionString = connectionString };

            Resources.Add("ApplicationContext", _applicationContext);

            InitializeComponent();
        }

        public void InterfacesShow(object sender, RoutedEventArgs e)
        {
            var interfacesWindow = new InterfacesWindow(_applicationContext.InterfacesSaved)
            {
                Owner = this
            };
            interfacesWindow.Show();
        }
    }
}
