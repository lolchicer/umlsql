using Lolchicer.Umlsql.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel;

public class ApplicationContext : DbContext, INotifyPropertyChanged
{
    private string _connectionString = string.Empty;

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

    public DbSet<Method> Methods { get; set; } = null!;

    public DbSet<Argument> Arguments { get; set; } = null!;

    public DbSet<Getproperty> Getproperties { get; set; } = null!;

    public DbSet<Setproperty> Setproperties { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Interface>()
            .HasKey(@interface => @interface.Id);

        modelBuilder.Entity<Method>()
            .HasKey(method => new { method.Id, method.Interface });

        modelBuilder.Entity<Argument>()
            .HasKey(argument => new { argument.Id, argument.Method });

        modelBuilder.Entity<Getproperty>()
            .HasKey(getproperty => new { getproperty.Id, getproperty.Method });

        modelBuilder.Entity<Setproperty>()
            .HasKey(setproperty => new { setproperty.Id, setproperty.Method });

        modelBuilder.Entity<Interface>()
            .HasMany(@interface => @interface.Methods)
            .WithOne(method => method.Interface)
            .HasForeignKey(method => method.InterfaceId);

        modelBuilder.Entity<Interface>()
            .HasMany(@interface => @interface.Arguments)
            .WithOne(argument => argument.Type)
            .HasForeignKey(argument => argument.TypeId);

        modelBuilder.Entity<Interface>()
            .HasMany(@interface => @interface.Getproperties)
            .WithOne(getproperty => getproperty.Type)
            .HasForeignKey(getproperty => getproperty.TypeId);

        modelBuilder.Entity<Method>()
            .HasMany(method => method.Arguments)
            .WithOne(argument => argument.Method)
            .HasForeignKey(argument => new { argument.MethodId, argument.InterfaceId });

        modelBuilder.Entity<Method>()
            .HasMany(method => method.Getproperties)
            .WithOne(getproperty => getproperty.Method)
            .HasForeignKey(getproperty => new { getproperty.MethodId, getproperty.InterfaceId });

        modelBuilder.Entity<Method>()
            .HasMany(method => method.Setproperties)
            .WithOne(setproperty => setproperty.Method)
            .HasForeignKey(setproperty => new { setproperty.MethodId, setproperty.InterfaceId });
    }
}
