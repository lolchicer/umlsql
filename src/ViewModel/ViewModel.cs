namespace Lolchicer.Umlsql.ViewModel;

public interface IFunction : IRow, Model.IFunction { }

public interface IArgument : IRow, Model.IArgument
{
    new public IFunction Function { get; }
    new public IFunction Type { get; }
    Model.IFunction Model.IArgument.Function => Function;
    Model.IFunction Model.IArgument.Type => Type;
}

public interface IInterface : IRow, Model.IInterface
{
    new public IFunction Function { get; }
    Model.IFunction Model.IInterface.Function => Function;
}

public interface IMethod : IRow, Model.IMethod
{
    new public IArgument Argument { get; }
    Model.IArgument Model.IMethod.Argument => Argument;
}

public interface IGetproperty : IRow, Model.IGetproperty
{
    new public IMethod Method { get; }
    Model.IMethod Model.IGetproperty.Method => Method;
}

public interface ISetproperty : IRow, Model.ISetproperty
{
    new public IMethod Method { get; }
    Model.IMethod Model.ISetproperty.Method => Method;
}
