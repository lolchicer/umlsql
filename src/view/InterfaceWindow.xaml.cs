using Lolchicer.Umlsql.ViewModel;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lolchicer.Umlsql.View;

public partial class InterfaceWindow : Window
{
    public InterfaceWindow(Interface @interface)
    {
        Resources.Add("Interface", @interface);

        InitializeComponent();
    }
}
