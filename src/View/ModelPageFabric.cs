using Lolchicer.Umlsql.View.Controls;

namespace Lolchicer.Umlsql.View;

public class ModelPageFabric(IModelGetter<ViewModel.Core.Model> getter) : IModelPageFabric
{
    public ModelPage ModelPage => new(getter.Model);
}
