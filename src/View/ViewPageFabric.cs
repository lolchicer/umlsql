namespace Lolchicer.Umlsql.View;

public class ViewPageFabric(ViewModel.IModelGetter<ViewModel.Core.View> getter) : IModelPageFabric
{
    public ModelPage ModelPage => new(getter.Model);
}
