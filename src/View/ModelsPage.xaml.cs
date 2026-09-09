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
    /// Логика взаимодействия для ModelsPage.xaml
    /// </summary>
    public partial class ModelsPage : Page
    {
        private IModelPageFabric _modelPageFabric;
        private ITableController _tableController;

        public ModelsPage(IModelPageFabric modelPageFabric, ITableController tableController, IEnumerable<TextBox> idBoxes)
        {
            _modelPageFabric = modelPageFabric;
            _tableController = tableController;

            InitializeComponent();

            foreach (var idBox in idBoxes)
                IdPanel.Children.Add(idBox);
        }

        private void NavigateCardPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                _modelPageFabric.ModelPage
                );
        }

        private void CreateNewCard(object sender, RoutedEventArgs e)
        {
            _tableController.CreateNewCard();
        }
    }
}
