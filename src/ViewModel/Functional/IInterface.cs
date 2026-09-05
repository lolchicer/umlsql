namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface IInterface : Model.Functional.IInterface
{
    public new IFunction Function { get; }

    Model.Functional.IFunction
        Model.Functional.IInterface.Function
        => Function;
}
