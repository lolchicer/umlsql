namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface IArgument : Core.IModel, Model.Functional.IArgument
{
    public new IFunction Function { get; }
    public new IFunction Type { get; }

    Model.Functional.IFunction
        Model.Functional.IArgument.Function
        => Function;

    Model.Functional.IFunction
        Model.Functional.IArgument.Type
        => Type;
}
