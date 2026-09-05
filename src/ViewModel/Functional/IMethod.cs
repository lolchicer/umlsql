namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface IMethod : Model.Functional.IMethod
{
    public new IArgument Argument { get; }

    Model.Functional.IArgument
        Model.Functional.IMethod.Argument
        => Argument;
}
