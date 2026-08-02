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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        private ApplicationNameFabric nameFabric = new();

        public ApplicationContext ApplicationContext
        {
            get => (ApplicationContext)FindResource("ApplicationContext");
        }

        public ProductPage(ApplicationContext applicationContext)
        {
            Resources.Add("ApplicationContext", applicationContext);

            InitializeComponent();
        }

        private void NavigateRowsPage<T>(
            IEnumerable<ISettableRow> rows,
            object sender,
            RoutedEventArgs e) where T : ISettableRow
        {
            NavigationService.Navigate(
                new RowsPage(rows)
                );
        }

        private void NavigateFunctionsPage(object sender, RoutedEventArgs e) =>
            NavigateRowsPage<Function>(ApplicationContext.Functions, sender, e);

        private void NavigateArgumentsPage(object sender, RoutedEventArgs e) =>
            NavigateRowsPage<Argument>(ApplicationContext.Arguments, sender, e);

        private void NavigateInterfacesPage(object sender, RoutedEventArgs e) =>
            NavigateRowsPage<Interface>(ApplicationContext.Interfaces, sender, e);

        private void NavigateMethodsPage(object sender, RoutedEventArgs e) =>
            NavigateRowsPage<Method>(ApplicationContext.Methods, sender, e);

        private void NavigateGetpropertiesPage(object sender, RoutedEventArgs e) =>
            NavigateRowsPage<Getproperty>(ApplicationContext.Getproperties, sender, e);

        private void NavigateSetpropertiesPage(object sender, RoutedEventArgs e) =>
            NavigateRowsPage<Setproperty>(ApplicationContext.Setproperties, sender, e);
    }
}
