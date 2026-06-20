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
    public class Argument
    {
        private int _id;

        private int _getpropertyId;

        private int _getpropertyInterfaceId;

        private int _typeId;

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

        [Column("method_id")]
        public int GetpropertyId
        {
            get => _getpropertyId;
            set
            {
                _getpropertyId = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [Column("method_object")]
        public int GetpropertyInterfaceId
        {
            get => _getpropertyInterfaceId;
            set
            {
                _getpropertyInterfaceId = value;
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

        [ForeignKey("Interface")]
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
