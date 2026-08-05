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
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lolchicer.Umlsql.View
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        private ApplicationNamesSetter _namesSetter = new(new ApplicationNameFabric());

        public ApplicationContext ApplicationContext
        {
            get => (ApplicationContext)FindResource("ApplicationContext");
        }

        public ProductPage(ApplicationContext applicationContext)
        {
            Resources.Add("ApplicationContext", applicationContext);

            InitializeComponent();
        }

        private void NavigateModelsPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<ViewModel.Model>)_namesSetter).SetNames(ApplicationContext.Models);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Models));
        }

        private void NavigateViewsPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<ViewModel.View>)_namesSetter).SetNames(ApplicationContext.Views);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Views));
        }

        private void NavigateFunctionsPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<Function>)_namesSetter).SetNames(ApplicationContext.Functions);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Functions));
        }

        private void NavigateArgumentsPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<Argument>)_namesSetter).SetNames(ApplicationContext.Arguments);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Arguments));
        }

        private void NavigateInterfacesPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<Interface>)_namesSetter).SetNames(ApplicationContext.Interfaces);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Interfaces));
        }

        private void NavigateMethodsPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<Method>)_namesSetter).SetNames(ApplicationContext.Methods);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Methods));
        }

        private void NavigateGetpropertiesPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<Getproperty>)_namesSetter).SetNames(ApplicationContext.Getproperties);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Getproperties));
        }

        private void NavigateSetpropertiesPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<Setproperty>)_namesSetter).SetNames(ApplicationContext.Setproperties);
            NavigationService.Navigate(new RowsPage(ApplicationContext.Setproperties));
        }
    }
}
