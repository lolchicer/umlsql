namespace Lolchicer.Umlsql.ViewModel.Core;

public class ViewGetter(ApplicationContext context, IIdTuple<View> tuple)
    : IModelGetter<View>
{
    public View Model => tuple.GetModel(context.Views);
}
