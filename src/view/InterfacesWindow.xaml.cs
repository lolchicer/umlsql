using Lolchicer.Umlsql.ViewModel;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
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
using System.Windows.Shapes;

namespace Lolchicer.Umlsql.View
{
    public partial class InterfacesWindow : Window
    {
        private IList<Interface> _interfaces;

        public IList<Interface> Interfaces
        {
            get => _interfaces;
            set => _interfaces = value;
        }

        public InterfacesWindow(IList<Interface> interfaces)
        {
            _interfaces = interfaces;

            Resources.Add("Interfaces", _interfaces);

            InitializeComponent();
        }

        public void InterfaceShow(object sender, RoutedEventArgs e)
        {
            var interfaceWindow = new InterfaceWindow(_interfaces[(int)((Button)sender).Content])
            {
                Owner = this
            };
            interfaceWindow.Show();
        }
    }
}
