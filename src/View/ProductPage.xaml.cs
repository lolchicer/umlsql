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
            ((INamesSetter<ViewModel.Model>)_namesSetter).SetNames(ApplicationContext.Models);
            ModelIdBoxTuple modelIdBoxTuple = new();
            ModelsRowPageFabric modelsRowPageFabric = new(
                new ModelGetter(
                    ApplicationContext,
                    modelIdBoxTuple));
            NavigationService.Navigate(new RowsPage(modelsRowPageFabric, modelIdBoxTuple.IdBoxes));
        }

        private void NavigateViewsPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<ViewModel.View>)_namesSetter).SetNames(ApplicationContext.Views);
            ViewIdBoxTuple viewIdBoxTuple = new();
            ViewsRowPageFabric viewsRowPageFabric = new(
                new ViewGetter(
                    ApplicationContext,
                    viewIdBoxTuple));
            NavigationService.Navigate(new RowsPage(viewsRowPageFabric, viewIdBoxTuple.IdBoxes));
        }
    }
}
