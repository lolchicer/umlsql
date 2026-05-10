using System.ComponentModel;
using System.Windows;

namespace Lolchicer.Umlsql;

public class ConnectionContext : INotifyPropertyChanged
{
    private string _connectionString = string.Empty;

    public event PropertyChangedEventHandler? PropertyChanged;

    public required string ConnectionString
    {
        get => _connectionString;
        set
        {
            _connectionString = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ConnectionString)));
        }
    }
}
