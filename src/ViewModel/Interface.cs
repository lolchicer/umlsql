using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel
{
    [Table("objects")]
    public class Interface : IInterface, INotifyPropertyChanged
    {
        private int _id;

        public event PropertyChangedEventHandler? PropertyChanged;

        [Key]
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

        [InverseProperty("Interface")]
        public ICollection<Setproperty> Setproperties { get; } = new List<Setproperty>();
        [InverseProperty("Interface")]
        public ICollection<Getproperty> Getproperties { get; } = new List<Getproperty>();
        [InverseProperty("Type")]
        public ICollection<Getproperty> GetpropertyTypes { get; } = new List<Getproperty>();
        [InverseProperty("Type")]
        public ICollection<Argument> ArgumentTypes { get; } = new List<Argument>();
    }
}
