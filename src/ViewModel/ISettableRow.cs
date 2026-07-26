namespace Lolchicer.Umlsql.ViewModel;

public interface ISettableRow : IRow
{
    public new string Name
    {
        get;
        set;
    }

    string IRow.Name => Name;
}
