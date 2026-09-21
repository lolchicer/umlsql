namespace Lolchicer.Umlsql.ViewModel.Documentational;

public class DocumentGetter(ApplicationContext context, IIdTuple<Document> tuple)
    : IModelGetter<Document>
{
    public Document Model => tuple.GetModel(context.Documents);
}
