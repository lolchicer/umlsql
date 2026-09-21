namespace Lolchicer.Umlsql.ViewModel.Iterational;

public class RedactionGetter(ApplicationContext context, IIdTuple<Redaction> tuple)
    : IModelGetter<Redaction>
{
    public Redaction Model => tuple.GetModel(context.Redactions);
}
