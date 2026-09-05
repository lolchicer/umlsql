namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface ISetproperty : Model.Functional.ISetproperty
{
    public new IMethod Method { get; }

    Model.Functional.IMethod
        Model.Functional.ISetproperty.Method
        => Method;
}
