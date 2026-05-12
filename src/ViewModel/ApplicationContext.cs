using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel;

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

    [NotMapped]
    public IList<Interface> InterfacesSaved
    {
        get => Interfaces.ToList();
    }

    public Interface Interface => (
        from value in Interfaces
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
