using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public interface IIdBoxTuple<T>
    : ViewModel.IIdTuple<T>
    where T : ViewModel.Core.IModel
{
    public IEnumerable<TextBox> IdBoxes { get; }
}
