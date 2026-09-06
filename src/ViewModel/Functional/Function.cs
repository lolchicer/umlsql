using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Function : Model.Functional.IFunction, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public IEnumerable<Argument> Arguments { get; } = [];
    public IEnumerable<Argument> ArgumentTypes { get; } = [];
    public IEnumerable<Interface> Interfaces { get; } = [];
}
