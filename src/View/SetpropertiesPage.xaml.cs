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
    /// Логика взаимодействия для SetpropertiesPage.xaml
    /// </summary>
    public partial class SetpropertiesPage : Page
    {
        public IList<Setproperty> Setproperties
        {
            get => (IList<Setproperty>)FindResource("Setproperties");
        }

        public SetpropertiesPage(IEnumerable<Setproperty> setproperties)
        {
            Resources.Add("Setproperties", new List<Setproperty>());

            foreach (var setproperty in setproperties)
                Setproperties.Add(setproperty);

            InitializeComponent();
        }

        private void NavigateSetpropertyPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new SetpropertyPage(Setproperties[(int)((Button)sender).Content])
                );
        }
    }
}
