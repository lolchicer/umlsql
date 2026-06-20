using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("fields")]
    public class Getproperty
    {
        private int _id;

        private int _interfaceId;

        private int _typeId;

        private Interface _interface;

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

        [Column("object")]
        public int InterfaceId
        {
            get => _interfaceId;
            set
            {
                _interfaceId = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [Column("type")]
        public int TypeId
        {
            get => _typeId;
            set
            {
                _typeId = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [ForeignKey("object")]
        public Interface Interface
        {
            get => _interface;
            set
            {
                _interface = value;
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

        [InverseProperty("Getproperty")]
        public ICollection<Argument> Arguments { get; } = new List<Argument>();
    }
}