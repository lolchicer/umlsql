using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Getproperty : Model.Functional.IGetproperty, INotifyPropertyChanged
{
    private Method _method;

    public event PropertyChangedEventHandler? PropertyChanged;

    public required Method Method
    {
        get => _method;
        set
        {
            _method = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    Model.Functional.IMethod Model.Functional.IGetproperty.Method => Method;
}
