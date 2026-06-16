using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("arguments")]
    public class Argument
    {
        private int _id;

        private int _getpropertyId;

        private int _getpropertyInterface;

        private int _type;

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
        public int GetpropertyInterface
        {
            get => _getpropertyInterface;
            set
            {
                _getpropertyInterface = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        [Column("type")]
        public int Type
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
