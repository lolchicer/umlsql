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
    /// Логика взаимодействия для RowPage.xaml
    /// </summary>
    public partial class RowPage<T> : Page where T : ISettableRow
    {
        private INameFabric<T> _nameFabric;

        public RowPage(T t, INameFabric<T> nameFabric)
        {
            _nameFabric = nameFabric;

            t.Name = _nameFabric.Name(t);

            Resources.Add("Row", t);

            InitializeComponent();
        }
    }
}
