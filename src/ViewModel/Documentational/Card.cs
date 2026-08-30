using Lolchicer.Umlsql.Model.Core;
using Lolchicer.Umlsql.Model.Documentational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel.Documentational
{
    public class Card : ICard, INotifyPropertyChanged
    {
        private int _id;
        private Core.Model _model;
        private string _name;
        private string _definition;

        public event PropertyChangedEventHandler? PropertyChanged;

        public required int Id
        {
            get => _id;
            set
            {
                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            }
        }

        public required int ModelId
        {
            get;
            set;
        }

        public required Core.Model Model
        {
            get => _model;
            set
            {
                _model = value;
                {
                    _model = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                {
                    _name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
                }
            }
        }
        public string Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                {
                    _definition = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
                }
            }
        }

        IModel ICard.Model => Model;
    }
}
