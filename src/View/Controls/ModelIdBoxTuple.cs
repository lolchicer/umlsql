using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class ModelIdBoxTuple
    : IIdBoxTuple<ViewModel.Core.Model>
{
    private ModelGetter _getter;

    private readonly TextBox _idBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public ViewModel.Core.Model Model
    {
        get
        {
            _getter.Id = Convert.ToInt32(_idBox.Text);
            return _getter.Model;
        }
    }

    public TextBox IdBox => _idBox;

    public ModelIdBoxTuple(ModelGetter getter)
    {
        _getter = getter;
        _idBox = new();
        _idBoxes = [_idBox];
    }
}
