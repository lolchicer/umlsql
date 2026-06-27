using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lolchicer.Umlsql;

public class ApplicationContext : DbContext, INotifyPropertyChanged
{
    private string _connectionString;

    public event PropertyChangedEventHandler? PropertyChanged;

    public required string ConnectionString
    {
        get => _connectionString;
        set
        {
            _connectionString = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }
}
