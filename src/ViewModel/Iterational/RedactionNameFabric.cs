namespace Lolchicer.Umlsql.ViewModel.Iterational;

public class RedactionNameFabric :
    INameFabric<Redaction>
{
    string INameFabric<Redaction>.Name(Redaction t) =>
        string.Concat(
            "i", t.ModelId.ToString(),
            "m", t.Id.ToString());
}
