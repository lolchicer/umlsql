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
using Lolchicer.Umlsql.View.Controls;

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
            ModelIdBoxTuple idBoxTuple = new();
            ViewModel.Core.ModelGetter getter = new(ApplicationContext, idBoxTuple);
            ModelPageFabric pageFabric = new(getter);
            ModelTableController tableController = new(
                ApplicationContext,
                idBoxTuple);
            NavigationService.Navigate(new ModelsPage(pageFabric, tableController, idBoxTuple.IdBoxes));
        }

        private void NavigateViewsPage(object sender, RoutedEventArgs e)
        {
            ViewIdBoxTuple idBoxTuple = new();
            ViewModel.Core.ViewGetter getter = new(ApplicationContext, idBoxTuple);
            ViewPageFabric pageFabric = new(getter);
            ViewTableController tableController = new(
                ApplicationContext,
                idBoxTuple);
            NavigationService.Navigate(new ModelsPage(pageFabric, tableController, idBoxTuple.IdBoxes));
        }

        private void NavigateCardsPage(object sender, RoutedEventArgs e)
        {
            CardIdBoxTuple idBoxTuple = new();
            ViewModel.Documentational.CardGetter getter = new(ApplicationContext, idBoxTuple);
            CardPageFabric pageFabric = new(getter);
            CardTableController tableController = new(
                ApplicationContext,
                idBoxTuple);
            NavigationService.Navigate(new ModelsPage(pageFabric, tableController, idBoxTuple.IdBoxes));
        }
    }
}
