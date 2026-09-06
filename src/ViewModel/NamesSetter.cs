namespace Lolchicer.Umlsql.ViewModel
{
    public interface INamesSetter<T> where T : Model.Core.IModel
    {
        public void SetNames(IEnumerable<T> ts);
    }

    public static class INamesSetting
    {
        public static void SetNames<T>(this IEnumerable<T> ts, INamesSetter<T> namesSetter)
            where T : ISettableRow
            => namesSetter.SetNames(ts);
    }

    public class ApplicationNamesSetter :
        INamesSetter<Core.Model>,
        INamesSetter<Core.View>,
        INamesSetter<Functional.Function>,
        INamesSetter<Functional.Argument>,
        INamesSetter<Functional.Interface>,
        INamesSetter<Functional.Method>,
        INamesSetter<Functional.Getproperty>,
        INamesSetter<Functional.Setproperty>
    {
        private ApplicationNameFabric _nameFabric;

        private void SetNames<T>(IEnumerable<T> rows, INameFabric<T> nameFabric)
            where T : ISettableRow
        {
            foreach (var row in rows)
                row.Name = row.Name(nameFabric);
        }

        void INamesSetter<Core.Model>.SetNames(IEnumerable<Core.Model> models) =>
            SetNames(models, _nameFabric);
        void INamesSetter<Core.View>.SetNames(IEnumerable<Core.View> views) =>
            SetNames(views, _nameFabric);
        void INamesSetter<Functional.Function>.SetNames(IEnumerable<Functional.Function> functions) =>
            SetNames(functions, _nameFabric);
        void INamesSetter<Functional.Argument>.SetNames(IEnumerable<Functional.Argument> arguments) =>
            SetNames(arguments, _nameFabric);
        void INamesSetter<Functional.Interface>.SetNames(IEnumerable<Functional.Interface> interfaces) =>
            SetNames(interfaces, _nameFabric);
        void INamesSetter<Functional.Method>.SetNames(IEnumerable<Functional.Method> methods) =>
            SetNames(methods, _nameFabric);
        void INamesSetter<Functional.Getproperty>.SetNames(IEnumerable<Functional.Getproperty> getproperties) =>
            SetNames(getproperties, _nameFabric);
        void INamesSetter<Functional.Setproperty>.SetNames(IEnumerable<Functional.Setproperty> setproperties) =>
            SetNames(setproperties, _nameFabric);

        public ApplicationNamesSetter(ApplicationNameFabric nameFabric)
        {
            _nameFabric = nameFabric;
        }
    }
}
