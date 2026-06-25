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
    [PrimaryKey("Id", "Getproperty")]
    public class Argument : IInterface, INotifyPropertyChanged
    {
        private int _id;

        private Getproperty _getproperty;

        private Interface _type;

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
        [ForeignKey("method_object, method_id")]
        public Getproperty Getproperty
        {
            get => _getproperty;
            set
            {
                _getproperty = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

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
    }
}
