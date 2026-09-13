using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class ModelIdBoxTuple
    : IIdBoxTuple<ViewModel.Core.Model>, ViewModel.Core.IModelIdTuple
{
    private readonly TextBox _idBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public TextBox IdBox => _idBox;

    public int Id => Convert.ToInt32(IdBox.Text);

    public ModelIdBoxTuple()
    {
        _idBox = new();
        _idBoxes = [_idBox];
    }
}
