using Lolchicer.Umlsql.View.Controls;

namespace Lolchicer.Umlsql.View;

public class ViewPageFabric(IModelGetter<ViewModel.Core.IView> getter) : IModelPageFabric
{
    public ModelPage ModelPage => new(getter.Model);
}
