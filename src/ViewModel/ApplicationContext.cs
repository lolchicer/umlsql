using Lolchicer.Umlsql.Model;
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
            .HasKey(method => new { method.Id, method.InterfaceId });

        modelBuilder.Entity<Argument>()
            .HasKey(argument => new { argument.Id, argument.MethodId, argument.InterfaceId });

        modelBuilder.Entity<Getproperty>()
            .HasKey(getproperty => new { getproperty.Id, getproperty.MethodId });

        modelBuilder.Entity<Setproperty>()
            .HasKey(setproperty => new { setproperty.Id, setproperty.MethodId });

        modelBuilder.Entity<Method>()
            .HasOne(method => method.Argument)
            .WithMany(@interface => @interface.Methods)
            .HasForeignKey(method => method.InterfaceId)
            .HasPrincipalKey(@interface => @interface.Id);

        modelBuilder.Entity<Argument>()
            .HasOne(argument => argument.Method)
            .WithMany(method => method.Arguments)
            .HasForeignKey(argument => new { argument.MethodId, argument.InterfaceId })
            .HasPrincipalKey(method => new { method.Id, method.InterfaceId });

        modelBuilder.Entity<Argument>()
            .HasOne(argument => argument.Type)
            .WithMany(type => type.Arguments)
            .HasForeignKey(argument => argument.TypeId)
            .HasPrincipalKey(type => type.Id);

        modelBuilder.Entity<Getproperty>()
            .HasOne(getproperty => getproperty.Method)
            .WithMany(method => method.Getproperties)
            .HasForeignKey(getproperty => new { getproperty.MethodId, getproperty.InterfaceId })
            .HasPrincipalKey(method => new { method.Id, method.InterfaceId });

        modelBuilder.Entity<Getproperty>()
            .HasOne(getproperty => getproperty.Type)
            .WithMany(type => type.Getproperties)
            .HasForeignKey(getproperty => getproperty.TypeId)
            .HasPrincipalKey(type => type.Id);

        modelBuilder.Entity<Setproperty>()
            .HasOne(setproperty => setproperty.Method)
            .WithMany(method => method.Setproperties)
            .HasForeignKey(setproperty => new { setproperty.MethodId, setproperty.InterfaceId })
            .HasPrincipalKey(method => new { method.Id, method.InterfaceId });
    }
}
