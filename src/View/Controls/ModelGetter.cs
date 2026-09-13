using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class ModelGetter(ApplicationContext context, IIdTuple<ViewModel.Core.Model> tuple)
    : IModelGetter<ViewModel.Core.Model>
{
    public ViewModel.Core.Model Model => tuple.GetModel(context.Models);
}
