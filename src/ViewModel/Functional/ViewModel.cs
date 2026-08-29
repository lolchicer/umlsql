namespace Lolchicer.Umlsql.ViewModel;

public interface IFunction : IRow, Umlsql.Model.IFunction { }

public interface IArgument : IRow, Umlsql.Model.IArgument
{
    new public IFunction Function { get; }
    new public IFunction Type { get; }
    Umlsql.Model.IFunction Umlsql.Model.IArgument.Function => Function;
    Umlsql.Model.IFunction Umlsql.Model.IArgument.Type => Type;
}

public interface IInterface : IRow, Umlsql.Model.IInterface
{
    new public IFunction Function { get; }
    Umlsql.Model.IFunction Umlsql.Model.IInterface.Function => Function;
}

public interface IMethod : IRow, Umlsql.Model.IMethod
{
    new public IArgument Argument { get; }
    Umlsql.Model.IArgument Umlsql.Model.IMethod.Argument => Argument;
}

public interface IGetproperty : IRow, Umlsql.Model.IGetproperty
{
    new public IMethod Method { get; }
    Umlsql.Model.IMethod Umlsql.Model.IGetproperty.Method => Method;
}

public interface ISetproperty : IRow, Umlsql.Model.ISetproperty
{
    new public IMethod Method { get; }
    Umlsql.Model.IMethod Umlsql.Model.ISetproperty.Method => Method;
}
