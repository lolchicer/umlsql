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
        modelBuilder.Entity<Function>()
            .HasKey(function => function.Id);

        modelBuilder.Entity<Argument>()
            .HasKey(argument => new { argument.Id, argument.FunctionId });

        modelBuilder.Entity<Interface>()
            .HasKey(@interface => new { @interface.Id, @interface.FunctionId });

        modelBuilder.Entity<Method>()
            .HasKey(method => new { method.Id, method.ArgumentId, method.FunctionId });

        modelBuilder.Entity<Getproperty>()
            .HasKey(getproperty => new { getproperty.Id, getproperty.MethodId, getproperty.ArgumentId, getproperty.FunctionId });

        modelBuilder.Entity<Setproperty>()
            .HasKey(setproperty => new { setproperty.Id, setproperty.MethodId, setproperty.ArgumentId, setproperty.FunctionId });

        modelBuilder.Entity<Argument>()
            .HasOne(argument => argument.Function)
            .WithMany(function => function.Arguments)
            .HasForeignKey(argument => argument.FunctionId)
            .HasPrincipalKey(function => function.Id);

        modelBuilder.Entity<Argument>()
            .HasOne(argument => argument.Type)
            .WithMany(type => type.Arguments)
            .HasForeignKey(argument => argument.TypeId)
            .HasPrincipalKey(type => type.Id);

        modelBuilder.Entity<Interface>()
            .HasOne(@interface => @interface.Function)
            .WithMany(function => function.Interfaces)
            .HasForeignKey(@interface => @interface.FunctionId)
            .HasPrincipalKey(function => function.Id);

        modelBuilder.Entity<Method>()
            .HasOne(method => method.Argument)
            .WithMany(argument => argument.Methods)
            .HasForeignKey(method => new { method.ArgumentId, method.FunctionId })
            .HasPrincipalKey(argument => new { argument.Id, argument.FunctionId });

        modelBuilder.Entity<Getproperty>()
            .HasOne(getproperty => getproperty.Method)
            .WithMany(method => method.Getproperties)
            .HasForeignKey(getproperty => new { getproperty.MethodId, getproperty.ArgumentId, getproperty.FunctionId })
            .HasPrincipalKey(method => new { method.Id, method.ArgumentId, method.FunctionId });

        modelBuilder.Entity<Setproperty>()
            .HasOne(setproperty => setproperty.Method)
            .WithMany(method => method.Setproperties)
            .HasForeignKey(setproperty => new { setproperty.MethodId, setproperty.ArgumentId, setproperty.FunctionId })
            .HasPrincipalKey(method => new { method.Id, method.ArgumentId, method.FunctionId });
    }
}
