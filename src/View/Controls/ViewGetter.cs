using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class ViewGetter(ApplicationContext context, IIdTuple<ViewModel.Core.View> tuple)
    : IModelGetter<ViewModel.Core.View>
{
    public ViewModel.Core.View Model => tuple.GetModel(context.Views);
}
