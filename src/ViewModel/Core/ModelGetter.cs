namespace Lolchicer.Umlsql.ViewModel.Core;

public class ModelGetter(ApplicationContext context, IIdTuple<Model> tuple)
    : IModelGetter<Model>
{
    public Model Model => tuple.GetModel(context.Models);
}
