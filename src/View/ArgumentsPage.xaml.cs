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
    /// Логика взаимодействия для ArgumentsPage.xaml
    /// </summary>
    public partial class ArgumentsPage : Page
    {
        public IList<Argument> Arguments
        {
            get => (IList<Argument>)FindResource("Arguments");
        }

        public ArgumentsPage(IEnumerable<Argument> arguments)
        {
            Resources.Add("Arguments", new List<Argument>());

            foreach (var argument in arguments)
                Arguments.Add(argument);

            InitializeComponent();
        }

        private void NavigateArgumentPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new ArgumentPage(Arguments[(int)((Button)sender).Content])
                );
        }
    }
}
