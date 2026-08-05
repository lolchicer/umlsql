namespace Lolchicer.Umlsql.ViewModel
{
    public interface INamesSetter<T> where T : ISettableRow
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
        INamesSetter<Model>,
        INamesSetter<View>,
        INamesSetter<Function>,
        INamesSetter<Argument>,
        INamesSetter<Interface>,
        INamesSetter<Method>,
        INamesSetter<Getproperty>,
        INamesSetter<Setproperty>
    {
        private ApplicationNameFabric _nameFabric;

        private void SetNames<T>(IEnumerable<T> rows, INameFabric<T> nameFabric)
            where T : ISettableRow
        {
            foreach (var row in rows)
                row.Name = row.Name(nameFabric);
        }

        void INamesSetter<Model>.SetNames(IEnumerable<Model> models) =>
            SetNames(models, _nameFabric);
        void INamesSetter<View>.SetNames(IEnumerable<View> views) =>
            SetNames(views, _nameFabric);
        void INamesSetter<Function>.SetNames(IEnumerable<Function> functions) =>
            SetNames(functions, _nameFabric);
        void INamesSetter<Argument>.SetNames(IEnumerable<Argument> arguments) =>
            SetNames(arguments, _nameFabric);
        void INamesSetter<Interface>.SetNames(IEnumerable<Interface> interfaces) =>
            SetNames(interfaces, _nameFabric);
        void INamesSetter<Method>.SetNames(IEnumerable<Method> methods) =>
            SetNames(methods, _nameFabric);
        void INamesSetter<Getproperty>.SetNames(IEnumerable<Getproperty> getproperties) =>
            SetNames(getproperties, _nameFabric);
        void INamesSetter<Setproperty>.SetNames(IEnumerable<Setproperty> setproperties) =>
            SetNames(setproperties, _nameFabric);

        public ApplicationNamesSetter(ApplicationNameFabric nameFabric)
        {
            _nameFabric = nameFabric;
        }
    }
}
