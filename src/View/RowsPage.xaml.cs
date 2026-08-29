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
    /// Логика взаимодействия для RowsPage.xaml
    /// </summary>
    public partial class RowsPage : Page
    {
        private IRowPageFabric _rowPageFabric;
        private ITableController _tableController;

        public RowsPage(IRowPageFabric rowPageFabric, ITableController tableController, IEnumerable<TextBox> idBoxes)
        {
            _rowPageFabric = rowPageFabric;
            _tableController = tableController;

            InitializeComponent();

            foreach (var idBox in idBoxes)
                IdPanel.Children.Add(idBox);
        }

        private void NavigateRowPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                _rowPageFabric.RowPage
                );
        }

        private void CreateNewRow(object sender, RoutedEventArgs e)
        {
            _tableController.CreateNewRow();
        }
    }
}
