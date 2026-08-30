using Lolchicer.Umlsql.Model.Documentational;
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
    /// Логика взаимодействия для CardPage.xaml
    /// </summary>
    public partial class CardPage : Page 
    {
        public CardPage(ICard card)
        {
            Resources.Add("Card", card);

            InitializeComponent();
        }
    }
}
