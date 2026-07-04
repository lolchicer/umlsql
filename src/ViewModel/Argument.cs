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

        private Method _method;

        private Interface _type;

        private string _name = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        [Column("id")]
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [Column("method")]
        public required int MethodId
        {
            get;
            set;
        }

        [Column("interface")]
        public required int InterfaceId
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

        public Method Method
        {
            get => _method;
            set
            {
                _method = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        public Interface Type
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

        IMethod IArgument.Method => Method;
        IInterface IArgument.Type => Type;
    }
}
