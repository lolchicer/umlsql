using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("functions")]
    public class Function : IFunction, INotifyPropertyChanged
    {
        private int _id;

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
    }
}
