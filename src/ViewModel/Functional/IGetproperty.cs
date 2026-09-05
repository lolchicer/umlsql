namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface IGetproperty : Model.Functional.IGetproperty
{
    public new IMethod Method { get; }

    Model.Functional.IMethod
        Model.Functional.IGetproperty.Method
        => Method;
}
