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
    public partial class RowsPage<T> : Page where T : ISettableRow
    {
        private INameFabric<T> _nameFabric;

        public IList<T> Rows
        {
            get => (IList<T>)FindResource("Rows");
        }

        public RowsPage(IEnumerable<T> ts, INameFabric<T> nameFabric)
        {
            Resources.Add("Rows", new List<T>());

            foreach (var row in ts)
                Rows.Add(row);

            InitializeComponent();
        }

        private void NavigateRowPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new RowPage<T>(Rows[(int)((Button)sender).Content], _nameFabric)
                );
        }
    }
}
