namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface IGetproperty
    : Core.IModel, Model.Functional.IGetproperty
{
    public new IMethod Method { get; }

    Model.Functional.IMethod
        Model.Functional.IGetproperty.Method
        => Method;
}
