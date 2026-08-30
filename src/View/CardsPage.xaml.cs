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
    /// Логика взаимодействия для CardsPage.xaml
    /// </summary>
    public partial class CardsPage : Page
    {
        private ICardPageFabric _cardPageFabric;
        private ITableController _tableController;

        public CardsPage(ICardPageFabric cardPageFabric, ITableController tableController, IEnumerable<TextBox> idBoxes)
        {
            _cardPageFabric = cardPageFabric;
            _tableController = tableController;

            InitializeComponent();

            foreach (var idBox in idBoxes)
                IdPanel.Children.Add(idBox);
        }

        private void NavigateCardPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                _cardPageFabric.CardPage
                );
        }

        private void CreateNewCard(object sender, RoutedEventArgs e)
        {
            _tableController.CreateNewCard();
        }
    }
}
