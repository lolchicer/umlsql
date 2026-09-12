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

    public DbSet<Core.Model> Models { get; set; } = null!;

    public DbSet<Core.View> Views { get; set; } = null!;

    public DbSet<Documentational.Card> Cards { get; set; } = null!;

    public DbSet<Functional.Function> Functions { get; set; } = null!;

    public DbSet<Functional.Argument> Arguments { get; set; } = null!;

    public DbSet<Functional.Interface> Interfaces { get; set; } = null!;

    public DbSet<Functional.Method> Methods { get; set; } = null!;

    public DbSet<Functional.Getproperty> Getproperties { get; set; } = null!;

    public DbSet<Functional.Setproperty> Setproperties { get; set; } = null!;

    // великий и могучий технический язык, который я не знаю.
    private void CreateModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Core.Model>()
            .HasKey(model => model.Id);
    }

    private void CreateView(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Core.View>()
            .HasKey(view => new { view.Id, view.ModelId });

        modelBuilder.Entity<Core.View>()
            .HasOne(view => view.Model)
            .WithMany(model => model.Views)
            .HasForeignKey(view => view.ModelId)
            .HasPrincipalKey(model => model.Id);

        modelBuilder.Entity<Core.View>()
            .HasOne(view => view.Type)
            .WithMany(type => type.ViewTypes)
            .HasForeignKey(view => view.TypeId)
            .HasPrincipalKey(type => type.Id);
    }

    private void CreateCard(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Documentational.Card>()
            .HasKey(card => new { card.Id, card.ModelId });

        modelBuilder.Entity<Documentational.Card>()
            .HasOne(card => card.Model)
            .WithMany(model => model.Cards)
            .HasForeignKey(card => card.ModelId)
            .HasPrincipalKey(model => model.Id);
    }

    private void CreateFunction(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Functional.Function>()
            .HasKey(function => function.Id);
    }

    private void CreateArgument(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Functional.Argument>()
            .HasKey(argument => new { argument.Id, argument.FunctionId });

        modelBuilder.Entity<Functional.Argument>()
            .HasOne(argument => argument.Function)
            .WithMany(function => function.Arguments)
            .HasForeignKey(argument => argument.FunctionId)
            .HasPrincipalKey(function => function.Id);

        modelBuilder.Entity<Functional.Argument>()
            .HasOne(argument => argument.Type)
            .WithMany(type => type.ArgumentTypes)
            .HasForeignKey(argument => argument.TypeId)
            .HasPrincipalKey(type => type.Id);
    }

    private void CreateInterface(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Functional.Interface>()
            .HasKey(@interface => new { @interface.Id, @interface.FunctionId });

        modelBuilder.Entity<Functional.Interface>()
            .HasOne(@interface => @interface.Function)
            .WithMany(function => function.Interfaces)
            .HasForeignKey(@interface => @interface.FunctionId)
            .HasPrincipalKey(function => function.Id);
    }

    private void CreateMethod(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Functional.Method>()
            .HasKey(method => new { method.Id, method.ArgumentId, method.FunctionId });

        modelBuilder.Entity<Functional.Method>()
            .HasOne(method => method.Argument)
            .WithMany(argument => argument.Methods)
            .HasForeignKey(method => new { method.ArgumentId, method.FunctionId })
            .HasPrincipalKey(argument => new { argument.Id, argument.FunctionId });
    }

    private void CreateGetproperty(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Functional.Getproperty>()
            .HasKey(getproperty => new { getproperty.Id, getproperty.MethodId, getproperty.ArgumentId, getproperty.FunctionId });

        modelBuilder.Entity<Functional.Getproperty>()
            .HasOne(getproperty => getproperty.Method)
            .WithMany(method => method.Getproperties)
            .HasForeignKey(getproperty => new { getproperty.MethodId, getproperty.ArgumentId, getproperty.FunctionId })
            .HasPrincipalKey(method => new { method.Id, method.ArgumentId, method.FunctionId });
    }

    private void CreateSetproperty(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Functional.Setproperty>()
            .HasKey(setproperty => new { setproperty.Id, setproperty.MethodId, setproperty.ArgumentId, setproperty.FunctionId });

        modelBuilder.Entity<Functional.Setproperty>()
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
        CreateCard(modelBuilder);
        CreateFunction(modelBuilder);
        CreateArgument(modelBuilder);
        CreateInterface(modelBuilder);
        CreateMethod(modelBuilder);
        CreateGetproperty(modelBuilder);
        CreateSetproperty(modelBuilder);
    }
}
