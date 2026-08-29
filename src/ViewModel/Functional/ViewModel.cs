namespace Lolchicer.Umlsql.ViewModel.Functional;

public interface IFunction : IRow, Umlsql.Model.Functional.IFunction { }

public interface IArgument : IRow, Umlsql.Model.Functional.IArgument
{
    new public IFunction Function { get; }
    new public IFunction Type { get; }
    Umlsql.Model.Functional.IFunction Umlsql.Model.Functional.IArgument.Function => Function;
    Umlsql.Model.Functional.IFunction Umlsql.Model.Functional.IArgument.Type => Type;
}

public interface IInterface : IRow, Umlsql.Model.Functional.IInterface
{
    new public IFunction Function { get; }
    Umlsql.Model.Functional.IFunction Umlsql.Model.Functional.IInterface.Function => Function;
}

public interface IMethod : IRow, Umlsql.Model.Functional.IMethod
{
    new public IArgument Argument { get; }
    Umlsql.Model.Functional.IArgument Umlsql.Model.Functional.IMethod.Argument => Argument;
}

public interface IGetproperty : IRow, Umlsql.Model.Functional.IGetproperty
{
    new public IMethod Method { get; }
    Umlsql.Model.Functional.IMethod Umlsql.Model.Functional.IGetproperty.Method => Method;
}

public interface ISetproperty : IRow, Umlsql.Model.Functional.ISetproperty
{
    new public IMethod Method { get; }
    Umlsql.Model.Functional.IMethod Umlsql.Model.Functional.ISetproperty.Method => Method;
}
