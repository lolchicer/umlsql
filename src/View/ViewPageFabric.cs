using Lolchicer.Umlsql.View.Controls;

namespace Lolchicer.Umlsql.View;

public class ViewPageFabric(IModelGetter<ViewModel.Core.View> getter) : IModelPageFabric
{
    public ModelPage ModelPage => new(getter.Model);
}
