using Lolchicer.Umlsql.Model;
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

namespace Lolchicer.Umlsql.View
{
    /// <summary>
    /// Логика взаимодействия для InterfacesPage.xaml
    /// </summary>
    public partial class InterfacesPage : Page
    {
        public IList<Interface> Interfaces
        {
            get => (IList<Interface>)FindResource("Interfaces");
        }

        public InterfacesPage(IEnumerable<Interface> interfaces)
        {
            Resources.Add("Interfaces", new List<Interface>());

            foreach (var @interface in interfaces)
                Interfaces.Add(@interface);

            InitializeComponent();
        }

        private void NavigateInterfacePage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new InterfacePage(Interfaces[(int)((Button)sender).Content])
                );
        }
    }
}
