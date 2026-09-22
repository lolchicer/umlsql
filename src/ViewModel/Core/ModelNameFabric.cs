namespace Lolchicer.Umlsql.ViewModel.Core;

public class ModelNameFabric :
    INameFabric<Model>
{
    string INameFabric<Model>.Name(Model t) =>
        string.Concat(
            "m", t.Id.ToString());
}
