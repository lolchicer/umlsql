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

    public DbSet<Model> Models { get; set; } = null!;

    public DbSet<View> Views { get; set; } = null!;

    public DbSet<Function> Functions { get; set; } = null!;

    public DbSet<Argument> Arguments { get; set; } = null!;

    public DbSet<Interface> Interfaces { get; set; } = null!;

    public DbSet<Method> Methods { get; set; } = null!;

    public DbSet<Getproperty> Getproperties { get; set; } = null!;

    public DbSet<Setproperty> Setproperties { get; set; } = null!;

    // великий и могучий технический язык, который я не знаю.
    private void CreateModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>()
            .HasKey(model => model.Id);
    }

    private void CreateView(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<View>()
            .HasKey(view => new { view.Id, view.ModelId });

        modelBuilder.Entity<View>()
            .HasOne(view => view.Model)
            .WithMany(model => model.Views)
            .HasForeignKey(view => view.ModelId)
            .HasPrincipalKey(model => model.Id);

        modelBuilder.Entity<View>()
            .HasOne(view => view.Type)
            .WithMany(type => type.ViewTypes)
            .HasForeignKey(view => view.TypeId)
            .HasPrincipalKey(type => type.Id);
    }

    private void CreateFunction(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Function>()
            .HasKey(function => function.Id);
    }

    private void CreateArgument(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Argument>()
            .HasKey(argument => new { argument.Id, argument.FunctionId });

        modelBuilder.Entity<Argument>()
            .HasOne(argument => argument.Function)
            .WithMany(function => function.Arguments)
            .HasForeignKey(argument => argument.FunctionId)
            .HasPrincipalKey(function => function.Id);

        modelBuilder.Entity<Argument>()
            .HasOne(argument => argument.Type)
            .WithMany(type => type.ArgumentTypes)
            .HasForeignKey(argument => argument.TypeId)
            .HasPrincipalKey(type => type.Id);
    }

    private void CreateInterface(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Interface>()
            .HasKey(@interface => new { @interface.Id, @interface.FunctionId });

        modelBuilder.Entity<Interface>()
            .HasOne(@interface => @interface.Function)
            .WithMany(function => function.Interfaces)
            .HasForeignKey(@interface => @interface.FunctionId)
            .HasPrincipalKey(function => function.Id);
    }

    private void CreateMethod(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Method>()
            .HasKey(method => new { method.Id, method.ArgumentId, method.FunctionId });

        modelBuilder.Entity<Method>()
            .HasOne(method => method.Argument)
            .WithMany(argument => argument.Methods)
            .HasForeignKey(method => new { method.ArgumentId, method.FunctionId })
            .HasPrincipalKey(argument => new { argument.Id, argument.FunctionId });
    }

    private void CreateGetproperty(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Getproperty>()
            .HasKey(getproperty => new { getproperty.Id, getproperty.MethodId, getproperty.ArgumentId, getproperty.FunctionId });

        modelBuilder.Entity<Getproperty>()
            .HasOne(getproperty => getproperty.Method)
            .WithMany(method => method.Getproperties)
            .HasForeignKey(getproperty => new { getproperty.MethodId, getproperty.ArgumentId, getproperty.FunctionId })
            .HasPrincipalKey(method => new { method.Id, method.ArgumentId, method.FunctionId });
    }

    private void CreateSetproperty(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Setproperty>()
            .HasKey(setproperty => new { setproperty.Id, setproperty.MethodId, setproperty.ArgumentId, setproperty.FunctionId });

        modelBuilder.Entity<Setproperty>()
            .HasOne(setproperty => setproperty.Method)
            .WithMany(method => method.Setproperties)
            .HasForeignKey(setproperty => new { setproperty.MethodId, setproperty.ArgumentId, setproperty.FunctionId })
            .HasPrincipalKey(method => new { method.Id, method.ArgumentId, method.FunctionId });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        CreateModel(modelBuilder);
        CreateView(modelBuilder);
        CreateFunction(modelBuilder);
        CreateArgument(modelBuilder);
        CreateInterface(modelBuilder);
        CreateMethod(modelBuilder);
        CreateGetproperty(modelBuilder);
        CreateSetproperty(modelBuilder);
    }
}
