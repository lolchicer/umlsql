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
        public IList<ISettableRow> Rows
        {
            get => (IList<ISettableRow>)FindResource("Rows");
        }

        public RowsPage(IEnumerable<ISettableRow> rows)
        {
            Resources.Add("Rows", new List<ISettableRow>());

            foreach (var row in rows)
                Rows.Add(row);

            InitializeComponent();
        }

        private void NavigateRowPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new RowPage(Rows[(int)((Button)sender).Content])
                );
        }
    }
}
