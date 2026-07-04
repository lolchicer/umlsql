using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("setproperties")]
    public class Setproperty : ISetproperty, INotifyPropertyChanged
    {
        private int _id;

        private Method _method;

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

        public Method Method
        {
            get => _method;
            set
            {
                _method = value;
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

        IMethod ISetproperty.Method => Method;
    }
}
