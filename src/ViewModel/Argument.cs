using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("arguments")]
    public class Argument : IArgument, INotifyPropertyChanged
    {
        private int _id;

        private Function _function;

        private Function _type;

        private string _name = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        [Column("id")]
        public required int Id
        {
            get => _id;
            set
            {
                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [Column("function")]
        public required int FunctionId
        {
            get;
            set;
        }

        [Column("type")]
        public required int TypeId
        {
            get;
            set;
        }

        public required Function Function
        {
            get => _function;
            set
            {
                _function = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        public required Function Type
        {
            get => _type;
            set
            {
                _type = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [NotMapped]
        public required string Name
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public IEnumerable<Method> Methods { get; } = [];

        IFunction IArgument.Function => Function;
        IFunction IArgument.Type => Type;
    }
}
