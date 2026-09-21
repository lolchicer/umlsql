namespace Lolchicer.Umlsql.View;

public class ModelPageFabric<T>(ViewModel.IModelGetter<T> getter) : IModelPageFabric where T : ViewModel.Core.IModel
{
    public ModelPage ModelPage => new(getter.Model);
}
