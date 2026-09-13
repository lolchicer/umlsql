namespace Lolchicer.Umlsql.View;

public class ModelPageFabric(ViewModel.IModelGetter<ViewModel.Core.Model> getter) : IModelPageFabric
{
    public ModelPage ModelPage => new(getter.Model);
}
