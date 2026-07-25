namespace Lolchicer.Umlsql.ViewModel;

interface IFunction : IRow, Model.IFunction { }

interface IArgument : IRow, Model.IArgument
{
    new public IFunction Function { get; }
    new public IFunction Type { get; }
    Model.IFunction Model.IArgument.Function => Function;
    Model.IFunction Model.IArgument.Type => Type;
}

interface IInterface : IRow, Model.IInterface
{
    new public IFunction Type { get; }
    Model.IFunction Model.IInterface.Type => Type;
}

interface IMethod : IRow, Model.IMethod
{
    new public IArgument Interface { get; }
    Model.IArgument Model.IMethod.Interface => Interface;
}

interface IGetproperty : IRow, Model.IGetproperty
{
    new public IMethod Method { get; }
    Model.IMethod Model.IGetproperty.Method => Method;
}

interface ISetproperty : IRow, Model.ISetproperty
{
    new public IMethod Method { get; }
    Model.IMethod Model.ISetproperty.Method => Method;
}
