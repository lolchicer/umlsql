using Lolchicer.Umlsql.View;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lolchicer.Umlsql;

public class ApplicationContext : DbContext, INotifyPropertyChanged
{
    private string _connectionString = "";

    public event PropertyChangedEventHandler? PropertyChanged;

    public string ConnectionString
    {
        get => _connectionString;
        set
        {
            _connectionString = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
            Database.EnsureCreated();
        }
    }

    public DbSet<Interface> Interfaces { get; set; } = null!;

    public Interface Interface => (
        from value in Interfaces
        where value.Id == 1
        select value
        ).First();

    public ApplicationContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }
}
