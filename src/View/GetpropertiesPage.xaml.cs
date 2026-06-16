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
    /// Логика взаимодействия для GetpropertiesPage.xaml
    /// </summary>
    public partial class GetpropertiesPage : Page
    {
        public IList<Getproperty> Getproperties
        {
            get => (IList<Getproperty>)FindResource("Getproperties");
        }

        public GetpropertiesPage(IEnumerable<Getproperty> getproperties)
        {
            Resources.Add("Getproperties", new List<Getproperty>());

            foreach (var getproperty in getproperties)
                Getproperties.Add(getproperty);

            InitializeComponent();
        }

        private void NavigateGetpropertyPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new GetpropertyPage(Getproperties[(int)((Button)sender).Content])
                );
        }
    }
}
