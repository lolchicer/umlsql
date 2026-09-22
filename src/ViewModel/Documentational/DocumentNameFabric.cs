namespace Lolchicer.Umlsql.ViewModel.Documentational;

public class DocumentNameFabric :
    INameFabric<Document>
{
    string INameFabric<Document>.Name(Document t) =>
        string.Concat(
            "d", t.ModelId.ToString(),
            "m", t.Id.ToString(),
            "on", t.DateContent.ToString());
}
