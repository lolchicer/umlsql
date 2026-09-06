using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Documentational;

public partial class Card
    : INotifyPropertyChanged, INameable, ICard
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Core.Model _model;

    private string _definition;
    
    private string _name;

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

    public required string Definition
    {
        get => _definition;
        set
        {
            _definition = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    public required string Name
    {
        get => _name;
        set
        {
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }   

    Core.IModel ICard.Model => Model;
}
