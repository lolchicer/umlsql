namespace Lolchicer.Umlsql.ViewModel.Core;

public class ViewNameFabric :
    INameFabric<View>
{
    string INameFabric<View>.Name(View t) =>
        string.Concat(
            "v", t.ModelId.ToString(),
            "m", t.Id.ToString());
}
