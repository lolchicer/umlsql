namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface ISetproperty : Core.IModel, Model.Functional.ISetproperty
{
    public new IMethod Method { get; }

    Model.Functional.IMethod
        Model.Functional.ISetproperty.Method
        => Method;
}
