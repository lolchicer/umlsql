using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("methods")]
    [PrimaryKey("Id", "Interface")]
    public class Setproperty
    {
        private int _id;

        private Interface _interface;

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
    }
}
