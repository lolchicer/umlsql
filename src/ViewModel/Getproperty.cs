using Lolchicer.Umlsql.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("getproperties")]
    [PrimaryKey("Id", "Method")]
    internal class Getproperty : IGetproperty, INotifyPropertyChanged
    {
        private int _id;

        private Method _method;

        private Interface _type;

        private string _name = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        [Key]
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

        [Key]
        [ForeignKey("method, interface")]
        public Method Method
        {
            get => _method;
            set
            {
                _method = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [Key]
        [ForeignKey("type")]
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

        IMethod IGetproperty.Method => Method;
        IInterface IGetproperty.Type => Type;
    }
}
