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
    /// Логика взаимодействия для GetpropertyPage.xaml
    /// </summary>
    public partial class GetpropertyPage : Page
    {
        public GetpropertyPage(Getproperty getproperty)
        {
            Resources.Add("Getproperty", getproperty);

            InitializeComponent();
        }
    }
}
