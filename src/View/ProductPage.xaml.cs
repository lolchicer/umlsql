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

        private void NavigateCardsPage(object sender, RoutedEventArgs e)
        {
            ((INamesSetter<ViewModel.Documentational.Card>)_namesSetter).SetNames(ApplicationContext.Cards);
            CardIdBoxTuple cardIdBoxTuple = new();
            CardPageFabric cardPageFabric = new(
                new CardGetter(
                    ApplicationContext,
                    cardIdBoxTuple));
            CardTableController cardTableController = new(
                ApplicationContext,
                cardIdBoxTuple);
            NavigationService.Navigate(new CardsPage(cardPageFabric, cardTableController, cardIdBoxTuple.IdBoxes));
        }
    }
}
