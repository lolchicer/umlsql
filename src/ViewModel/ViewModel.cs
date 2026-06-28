namespace Lolchicer.Umlsql.ViewModel;

interface IInterface : IRow, Model.IInterface { }
interface IMethod : IRow, Model.IMethod
{
    new public IInterface Interface { get; }
    Model.IInterface Model.IMethod.Interface => Interface;
}

interface IGetproperty : IRow, Model.IGetproperty
{
    new public IMethod Method { get; }
    new public IInterface Type { get; }
    Model.IMethod Model.IGetproperty.Method => Method;
    Model.IInterface Model.IGetproperty.Type => Type;
}

interface ISetproperty : IRow, Model.ISetproperty
{
    new public IMethod Method { get; }
    Model.IMethod Model.ISetproperty.Method => Method;
}

interface IArgument : IRow, Model.IArgument
{
    new public IMethod Method { get; }
    new public IInterface Type { get; }
    Model.IMethod Model.IArgument.Method => Method;
    Model.IInterface Model.IArgument.Type => Type;
}
